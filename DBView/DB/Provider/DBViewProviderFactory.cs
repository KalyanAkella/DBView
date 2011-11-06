using DBView.DTO;

namespace DBView.DB.Provider
{
    public class DBViewProviderFactory
    {
        public static IDBViewProvider RetrieveDbProvider(ConnectionDetail connectionDetail)
        {
            switch (connectionDetail.DBType)
            {
                case DBType.Oracle:
                    var dbProvider = new OracleProvider(connectionDetail);
                    dbProvider.OpenConnection();
                    return dbProvider;
                case DBType.MySql:
                    var mySqlProvider = new MySqlProvider(connectionDetail);
                    mySqlProvider.OpenConnection();
                    return mySqlProvider;
                case DBType.SqlServer:
                    var sqlServerProvider = new SqlServerProvider(connectionDetail);
                    sqlServerProvider.OpenConnection();
                    return sqlServerProvider;
                default:
                    return null;
            }
        }
    }
}
