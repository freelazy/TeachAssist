using System.Windows.Forms;
using TeachAssist.DAL;
using TeachAssist.Winform.Global;

namespace TeachAssist.Winform.Forms
{
    public partial class ConfigForm : BaseForm
    {
        public ConfigForm()
        {
            InitializeComponent();

            LoadParams();
            this.paramBox.CellValidating += DoUpdate;
        }

        void LoadParams()
        {
            this.paramBox.AutoGenerateColumns = false;
            this.paramBox.Rows.Clear();

            foreach (var param in SysParams.Items)
            {
                this.paramBox.Rows.Add(param.Key, param.Value.value, param.Value.type, param.Value.category);
            }
        }

        void DoUpdate(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                var row = this.paramBox.Rows[e.RowIndex];
                if (e.FormattedValue.ToString() != row.Cells[e.ColumnIndex].Value.ToString())
                {
                    new SysParamDAO().UpdateParam(row.Cells[0].Value.ToString(), e.FormattedValue.ToString());
                    SysParams.LoadParams();
                }
            }
            catch
            {
                e.Cancel = true;
            }
        }
    }

}
