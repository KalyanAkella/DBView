using DBView.DTO;

namespace DBView.Dialogs.DBDialogs
{
    public class DBDialogFactory
    {
        public static IDBDialog GetDBDialog(DBType dbTypeName)
        {
            switch (dbTypeName)
            {
                case DBType.Oracle:
                    return new OracleDBDialog();
                case DBType.MySql:
                    return new MySQLDBDialog();
                case DBType.SqlServer:
                    return new SqlServerDBDialog();
                default:
                    return null;
            }
        }
    }
}
