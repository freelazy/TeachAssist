using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace TeachAssist.DAL
{
    public class TiwenDAO
    {
        public DataTable ListAll()
        {
            var sql = "select id, name, gno, tiwen_cishu as cs, tiwen_fenshu as fs from students where state = 1";
            return DbHelper.DoExecuteQuery(sql);
        }

        public DataTable AllGroups()
        {
            var sql = @"select a.gno, b.name, c.cs, c.fs from groups a
                    left join students b on a.stuid = b.id
                    left join (select gno, SUM(tiwen_cishu) as cs, sum(tiwen_fenshu) as fs from students group by gno) c on a.gno = c.gno";
            return DbHelper.DoExecuteQuery(sql);
        }

        public void AddScore(string stuid, int score)
        {
            /*
                var conn = DbHelper.GetConnection();
                var command = new SqlCommand("insert into tiwen (stuid, score) values (@stuid, @score)", conn);
                var p1 = new SqlParameter("stuid", stuid);
                var p2 = new SqlParameter("score", score);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.ExecuteNonQuery();
            */

            /*
                var conn = DbHelper.GetConnection();
                var command = new SqlCommand("insert into tiwen (stuid, score) values (@stuid, @score)", conn);
                command.Parameters.Add(new SqlParameter("stuid", stuid));
                command.Parameters.Add(new SqlParameter("score", score));
                command.ExecuteNonQuery();
            */

            /*
                var conn = DbHelper.GetConnection();
                var command = new SqlCommand("insert into tiwen (stuid, score) values (@stuid, @score)", conn);
                command.Parameters.AddRange(new []
                {
                    new SqlParameter("stuid", stuid),
                    new SqlParameter("score", score)
                };
                command.ExecuteNonQuery();
            */

            using (var ts = new TransactionScope())
            {
                DbHelper.DoExecuteNonQuery(
                    "insert into tiwen (stuid, score) values (@stuid, @score)",
                    new SqlParameter("stuid", stuid),
                    new SqlParameter("score", score));

                //if (new Random().Next(3) > 1)  throw new Exception();

                DbHelper.DoExecuteNonQuery(
                    @"update students
                    set tiwen_cishu = tiwen_cishu + 1, tiwen_fenshu = tiwen_fenshu + @score
                    where id = @stuid",
                    new SqlParameter("stuid", stuid),
                    new SqlParameter("score", score));

                ts.Complete();
            }
        }

        public DataTable AllGroupsTemp1()
        {
            var sql = @"select a.gno as gno, b.name, c.cs, c.fs from groups a
                    left join students b on a.stuid = b.id
                    left join (select gno, SUM(tiwen_cishu) as cs, sum(tiwen_fenshu) as fs from students group by gno) c on a.gno = c.gno";
            return DbHelper.DoExecuteQuery(sql);
        }
    }
}
