using System.Collections.Generic;
using System.Data;
using System.Transactions;
using TeachAssist.DAL;

namespace TeachAssist.BLL
{
    public class TiwenService
    {
        TiwenDAO dal = new TiwenDAO();

        public DataTable GetAllStudent()
        {
            return dal.ListAll();
        }

        public DataTable GetAllGroup()
        {
            return dal.AllGroups();
        }

        public void UpdateStores(IEnumerable<(string id, int score)> scores)
        {
            using (var ts = new TransactionScope())
            {
                foreach ((string id, int score) in scores)
                {
                    dal.AddScore(id, score);
                }

                ts.Complete();
            }
        }

    }
}
