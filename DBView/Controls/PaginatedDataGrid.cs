using System;
using System.Windows.Forms;
using DBView.DB.Provider;

namespace DBView.Controls
{
    public partial class PaginatedDataGrid : UserControl
    {
        private const string COUNT_QUERY = "SELECT COUNT(*) FROM {0}";
        private const string OPEN_TABLE_QUERY = "SELECT * FROM {0}";
        private readonly IDBViewProvider dbViewProvider;

        private PaginatedDataGrid()
        {
            InitializeComponent();
            HookEvents();
            paginationPanel.Enabled = false;
            dataGridView.VirtualMode = true;
        }

        public PaginatedDataGrid(IDBViewProvider dbViewProvider) : this()
        {
            this.dbViewProvider = dbViewProvider;
        }

        public void OpenTable(string tableName)
        {
            var query = string.Format(OPEN_TABLE_QUERY, tableName);
            dataGridView.DataSource = dbViewProvider.ExecuteQuery(query).DataTable;
            SetRowCountOnHeader(tableName);
        }

        private void SetRowCountOnHeader(string tableName)
        {
            var countQuery = string.Format(COUNT_QUERY, tableName);
            var rowCount = dbViewProvider.ExecuteCountQuery(countQuery);
            rowCountLabel.Text = rowCount + " / " + rowCount;
        }

        private void HookEvents()
        {
            dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            dataGridView.CellValuePushed += dataGridView_CellValuePushed;
            dataGridView.DataError +=
                ((sender, e) =>
                 MessageBox.Show(string.Format("{0} {1}", e.Exception.Message, "Press <ESC> to cancel changes"), "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error));
        }

        private void dataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView_CellEndEdit(object sender, EventArgs e)
        {
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}