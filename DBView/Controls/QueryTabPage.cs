using System.Windows.Forms;
using DBView.DB;
using DBView.DB.Provider;

namespace DBView.Controls
{
    public partial class QueryTabPage : TabPage
    {
        public QueryTabPage(IDBViewProvider dbViewProvider) : base(dbViewProvider.ConnectionDetail.ConnName)
        {
            InitializeComponent(dbViewProvider);
            queryBox.QueryExecuted += dbViewQueryPage_QueryExecuted;
        }

        private void dbViewQueryPage_QueryExecuted(object sender, QueryEventArgs e)
        {
            queryDataGrid.DataSource = e.DBViewDataTable.DataTable;
            SetQueryStatusLabel(e.DBViewDataTable);
        }

        private void SetQueryStatusLabel(DBViewDataTable dbViewDataTable)
        {
            queryStatusLabel.Text = string.Empty;
            if (dbViewDataTable.RecordsAffected >= 0 && queryDataGrid.RowCount == 0)
                queryStatusLabel.Text = "Number of rows updated: " + dbViewDataTable.RecordsAffected;
            else queryStatusLabel.Text = "Number of records: " + queryDataGrid.RowCount;
        }
    }
}