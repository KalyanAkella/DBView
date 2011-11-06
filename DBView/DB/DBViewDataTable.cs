using System.Data;

namespace DBView.DB
{
    public class DBViewDataTable
    {
        private int recordsAffected;

        public DBViewDataTable()
        {
            DataTable = new DataTable();
        }

        public DataTable DataTable { get; set; }

        public int RecordsAffected
        {
            get { return recordsAffected; }
            set { recordsAffected = value == -1 ? 0 : value; }
        }
    }
}