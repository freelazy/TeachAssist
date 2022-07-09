using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TeachAssist.DAL
{
    public class SysParamDAO
    {
        public List<(string, string, string, int)> GetAllParams()
        {
            var ps = DbHelper.DoExecuteQuery("select name, value, category, type from parameters");
            List<(string, string, string, int)> results = new();
            foreach (DataRow row in ps.Rows)
            {
                results.Add((row[0].ToString(), row[1].ToString(), row[2].ToString(), (int)row[3]));
            }
            return results;
        }

        public void UpdateParam(string name, string value)
        {
            DbHelper.DoExecuteNonQuery(
                "update parameters set value=@value where name=@name"
                , new SqlParameter("name", name)
                , new SqlParameter("value", value));
        }
    }
}
