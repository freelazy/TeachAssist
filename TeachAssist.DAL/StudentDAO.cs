using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using TeachAssist.Models;

namespace TeachAssist.DAL
{
    public class StudentDAO
    {
        public List<Student> GetStudents(int state = -1)
        {
            using var connection = DbHelper.GetConnection();

            var sql = "select id, name, homecity, telephone, state, duyin from students";

            var command = new SqlCommand() { Connection = connection };

            if (state == -1)
            {
                command.CommandText = sql;
            }
            else
            {
                command.CommandText = sql + " where state=@state";
                command.Parameters.AddWithValue("@state", state);
            }

            using var reader = command.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read())
            {
                students.Add(new Student()
                {
                    Id = reader[0] as string,
                    Name = reader["name"] as string,
                    Homecity = reader[2] as string,
                    Telephone = reader[3] as string,
                    State = (int)reader[4],
                    Duyin = reader[5] as string
                });
            }
            return students;
        }

        public List<Student> SearchStudents(string condition)
        {
            using var connection = DbHelper.GetConnection();

            var sql = @"select id, name, homecity, telephone, state, duyin from students
                        where name like @name or homecity like @hc or id like @id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", $"%{condition}%");
            command.Parameters.AddWithValue("@hc", $"%{condition}%");
            command.Parameters.AddWithValue("@id", $"%{condition}%");

            using var reader = command.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read())
            {
                students.Add(new Student()
                {
                    Id = reader[0] as string,
                    Name = reader["name"] as string,
                    Homecity = reader[2] as string,
                    Telephone = reader[3] as string,
                    State = (int)reader[4],
                    Duyin = reader[5] as string
                });
            }
            return students;
        }

        public Student GetStudentById(string id)
        {
            using var connection = DbHelper.GetConnection();

            var sql = @"select id, name, homecity, telephone, state, duyin from students where id=@id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Student()
                {
                    Id = reader[0] as string,
                    Name = reader["name"] as string,
                    Homecity = reader[2] as string,
                    Telephone = reader[3] as string,
                    State = (int)reader[4],
                    Duyin = reader[5] as string
                };
            }
            return null;
        }

        public int AddStudent(Student student)
        {
            return DbHelper.DoExecuteNonQuery(
                @"insert into students (id, name, homecity, telephone, state, duyin) values (@id, @name, @hc, @tel, @state, @duyin)",
                new SqlParameter("@id", student.Id),
                new SqlParameter("@name", student.Name),
                new SqlParameter("@hc", student.Homecity),
                new SqlParameter("@tel", student.Telephone),
                new SqlParameter("@state", student.State),
                new SqlParameter("@duyin", student.Duyin)
            );
        }

        public int UpdateStudent(Student student)
        {
            return DbHelper.DoExecuteNonQuery(
                @"update students set homecity=@hc, telephone=@tel, state=@state where id=@id",
                new SqlParameter("id", student.Id),
                new SqlParameter("hc", student.Homecity),
                new SqlParameter("tel", student.Telephone),
                new SqlParameter("state", student.State)
            );
        }

        public int DeleteStudent(string id)
        {
            return DbHelper.DoExecuteNonQuery(
                @"delete students where id=@id",
                new SqlParameter("id", id)
            );
        }

        public DataSet GetStudentsAndGroups()
        {
            DataSet ds = new();

            var dt1 = DbHelper.DoExecuteQuery("select * from students");
            var dt2 = DbHelper.DoExecuteQuery("select * from groups");

            dt1.TableName = "st";
            dt2.TableName = "gp";

            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);

            return ds;
        }

        public void SaveGroups(List<(int id, string leader, List<string> members)> groups)
        {
            using var scope = new TransactionScope();

            DbHelper.DoExecuteNonQuery("update students set gno = null");
            DbHelper.DoExecuteNonQuery("delete from groups");

            foreach (var group in groups)
            {
                DbHelper.DoExecuteNonQuery("insert into groups (gno, stuid) values (@gno, @stuid)"
                    , new SqlParameter("gno", group.id)
                    , new SqlParameter("stuid", group.leader));
                foreach (var id in group.members)
                {
                    DbHelper.DoExecuteNonQuery("update students set gno = @gno where id = @id"
                        , new SqlParameter("gno", group.id)
                        , new SqlParameter("id", id));
                }
            }

            scope.Complete();
        }
    }
}
