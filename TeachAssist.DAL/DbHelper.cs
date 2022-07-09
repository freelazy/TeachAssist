using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace TeachAssist.DAL
{
    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            var connStr = ConfigurationManager.ConnectionStrings["mssql"].ConnectionString;
            var connection = new SqlConnection(connStr);
            connection.Open();
            return connection;
        }

        public static int DoExecuteNonQuery(string sql, params SqlParameter[] sqlParams)
        {
            using var connection = GetConnection();

            var command = new SqlCommand { CommandText = sql, Connection = connection };
            if (sqlParams != null)
            {
                command.Parameters.AddRange(sqlParams);
            }

            return command.ExecuteNonQuery();
        }

        public static object DoExecuteScalar(string sql, params SqlParameter[] sqlParams)
        {
            using var connection = GetConnection();

            var command = new SqlCommand { CommandText = sql, Connection = connection };
            if (sqlParams != null)
            {
                command.Parameters.AddRange(sqlParams);
            }

            return command.ExecuteScalar();
        }

        public static DataTable DoExecuteQuery(string sql, params SqlParameter[] sqlParams)
        {
            using var connection = GetConnection();

            var adapter = new SqlDataAdapter(sql, connection);
            if (sqlParams != null)
            {
                adapter.SelectCommand.Parameters.AddRange(sqlParams);
            }

            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        // 辅助方法
        public static void Show(DataTable table, Action<DataRow> act)
        {
            foreach (DataRow row in table.Rows) act(row);
        }

        public static List<T> ToModelList<T>(this DataTable dt)
        {
            return
                dt.Rows.Cast<DataRow>()
                .Select(r =>
                {
                    T t = (T)Activator.CreateInstance(typeof(T));
                    foreach (PropertyInfo p in typeof(T).GetProperties())
                    {
                        p.SetValue(t, r[p.Name.ToLower()]);
                    }
                    return t;
                })
                .ToList();
        }

        public static List<T> ToModelList2<T>(this DataTable dt)
        {
            List<T> lst = (List<T>)Activator
                .CreateInstance(typeof(List<>).MakeGenericType(typeof(T)));

            foreach (DataRow r in dt.Rows)
            {
                T t = (T)Activator.CreateInstance(typeof(T));
                foreach (PropertyInfo p in typeof(T).GetProperties())
                {
                    if (p.GetCustomAttribute(typeof(MyIgnoreAttribute)) == null)
                    {
                        var cn = p.Name;
                        var ma = p.GetCustomAttribute(typeof(MyMappingAttribute)) as MyMappingAttribute;
                        if (ma != null)
                        {
                            cn = ma.Name;
                        }
                        p.SetValue(t, r[cn.ToLower()]);
                    }
                    else
                    {
                        var da = p.GetCustomAttribute<MyDefaultAttribute>();
                        if (da != null)
                        {
                            p.SetValue(t, da.Value);
                        }
                    }
                }
                lst.GetType().GetMethod("Add").Invoke(lst, new object[] { t });
            }

            return lst;
        }

        public static void Save<T>(T o)
        {
            var type = o.GetType();
            var ps = type.GetProperties();

            var ma = type.GetCustomAttribute<MyMappingAttribute>();
            var tn = ma == null ? type.Name.ToLower() : ma.Name;

            var s1 = string.Join(", ", ps.Select(p =>
            {
                var m = p.GetCustomAttribute<MyMappingAttribute>();
                return m == null ? p.Name.ToLower() : m.Name;
            }));
            var s2 = string.Join(", ", ps.Select(p => $"@{p.Name.ToLower()}"));
            var sql = $"insert into {tn} ({s1}) values ({s2})";

            var parameters = ps.Select(p =>
            {
                var n = p.Name.ToLower();
                var v = p.GetValue(o);
                return new SqlParameter(n, v);
            }).ToArray();

            //List<SqlParameter> psl = new();
            //foreach (var p in ps) // id, name, address
            //{
            //    var n = p.Name.ToLower();
            //    var v = p.GetValue(o);
            //    psl.Add(new SqlParameter(n, v));
            //}
            //var parameters2 = psl.ToArray();// [sp(id, 0), sp(name, ss)]

            Console.WriteLine(sql);
            DbHelper.DoExecuteQuery(sql, parameters);
        }
    }
}
