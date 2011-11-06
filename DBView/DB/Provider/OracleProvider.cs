using System.Data.Common;
using System.Data.OracleClient;
using DBView.DTO;

namespace DBView.DB.Provider
{
    public class OracleProvider : GenericDBProvider
    {
        private const string DATA_SOURCE =
            "(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1}))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={2})))";

        public OracleProvider(ConnectionDetail connectionDetail) : base(connectionDetail)
        {
        }

        protected override string AllTablesQuery
        {
            get { return "select TABLE_NAME from USER_TABLES order by TABLE_NAME"; }
        }

        protected override string AllPackagesQuery
        {
            get { return "select OBJECT_NAME from ALL_PROCEDURES group by OBJECT_NAME order by OBJECT_NAME"; }
        }

        protected override string AllViewsQuery
        {
            get { return "select VIEW_NAME from ALL_VIEWS order by VIEW_NAME"; }
        }

        protected override string AllColumnsQueryForGivenTable(string tableName)
        {
            return string.Format("select COLUMN_NAME from USER_TAB_COLUMNS where TABLE_NAME = '{0}' order by COLUMN_ID",
                                 tableName);
        }

        protected override string AllPrimaryKeyColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "select acc.COLUMN_NAME from ALL_CONSTRAINTS ac, ALL_CONS_COLUMNS acc where ac.CONSTRAINT_NAME = acc.CONSTRAINT_NAME and ac.CONSTRAINT_TYPE = 'P' and ac.TABLE_NAME = '{0}'",
                    tableName);
        }

        protected override string AllForeignKeyColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "select acc.COLUMN_NAME from ALL_CONSTRAINTS ac, ALL_CONS_COLUMNS acc where ac.CONSTRAINT_NAME = acc.CONSTRAINT_NAME and ac.CONSTRAINT_TYPE = 'R' and ac.TABLE_NAME = '{0}'",
                    tableName);
        }

        protected override string AllConstraintsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "select CONSTRAINT_NAME from ALL_CONSTRAINTS where TABLE_NAME = '{0}' order by CONSTRAINT_NAME",
                    tableName);
        }

        protected override string AllTriggersQueryForGivenTable(string tableName)
        {
            return string.Format("select TRIGGER_NAME from ALL_TRIGGERS where TABLE_NAME = '{0}' order by TRIGGER_NAME",
                                 tableName);
        }

        protected override string AllIndexesQueryForGivenTable(string tableName)
        {
            return string.Format("select INDEX_NAME from ALL_INDEXES where TABLE_NAME = '{0}' order by INDEX_NAME",
                                 tableName);
        }

        protected override string AllProcsQueryForGivenPkg(string pkgName)
        {
            return
                string.Format(
                    "select PROCEDURE_NAME from ALL_PROCEDURES where OBJECT_NAME = '{0}' order by PROCEDURE_NAME",
                    pkgName);
        }

        protected override string QueryForPkgHeader(string pkgName)
        {
            return string.Format("select TEXT from ALL_SOURCE where NAME = '{0}' and TYPE = 'PACKAGE' order by LINE",
                                 pkgName);
        }

        protected override string QueryForPkgBody(string pkgName)
        {
            return
                string.Format("select TEXT from ALL_SOURCE where NAME = '{0}' and TYPE = 'PACKAGE BODY' order by LINE",
                              pkgName);
        }

        protected override string QueryForViewBody(string viewName)
        {
            return string.Format("select TEXT from ALL_VIEWS where VIEW_NAME = '{0}'", viewName);
        }

        protected override string AllTableNamesLikeQuery(string pattern)
        {
            return
                string.Format(
                    "select TABLE_NAME from USER_TABLES where TABLE_NAME like upper('{0}') order by TABLE_NAME", pattern);
        }

        public override void OpenConnection()
        {
            if (DbConnection != null) return;
            var stringBuilder = ConstructConnectionStringBuilder();
            DbConnection = new OracleConnection(stringBuilder.ConnectionString);
            DbConnection.Open();
        }

        private DbConnectionStringBuilder ConstructConnectionStringBuilder()
        {
            return new OracleConnectionStringBuilder
                       {
                           DataSource =
                               string.Format(DATA_SOURCE, ConnectionDetail.HostName, ConnectionDetail.PortNumber,
                                             ConnectionDetail.ServiceName),
                           UserID = ConnectionDetail.UserName,
                           Password = ConnectionDetail.PassWord
                       };
        }
    }
}