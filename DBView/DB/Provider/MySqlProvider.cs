using System;
using System.Data.Common;
using DBView.DTO;
using MySql.Data.MySqlClient;

namespace DBView.DB.Provider
{
    public class MySqlProvider : GenericDBProvider
    {
        public MySqlProvider(ConnectionDetail connectionDetail)
            : base(connectionDetail)
        {
        }

        protected override string AllTablesQuery
        {
            get
            {
                return
                    string.Format(
                        "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{0}' order by TABLE_NAME;",
                        ConnectionDetail.InitialCatalog);
            }
        }

        protected override string AllPackagesQuery
        {
            get { return "SELECT ROUTINE_NAME FROM INFORMATION_SCHEMA.ROUTINES order by ROUTINE_NAME;"; }
        }

        protected override string AllViewsQuery
        {
            get { return "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS order by TABLE_NAME;"; }
        }

        protected override string AllColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{0}' ORDER BY ORDINAL_POSITION;",
                    tableName);
        }

        protected override string AllPrimaryKeyColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{0}' AND COLUMN_KEY = 'PRI';",
                    tableName);
        }

        protected override string AllForeignKeyColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}' AND COLUMN_KEY = 'MUL';",
                    tableName);
        }

        protected override string AllConstraintsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE TABLE_NAME='{0}' ORDER BY CONSTRAINT_NAME;",
                    tableName);
        }

        protected override string AllTriggersQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT TRIGGER_NAME FROM INFORMATION_SCHEMA.TRIGGERS WHERE EVENT_OBJECT_TABLE = '{0}' ORDER BY TRIGGER_NAME;",
                    tableName);
        }

        protected override string AllIndexesQueryForGivenTable(string tableName)
        {
            return string.Format("SELECT INDEX_NAME FROM INFORMATION_SCHEMA.STATISTICS WHERE TABLE_NAME = '{0}';",
                                 tableName);
        }

        protected override string QueryForViewBody(string viewName)
        {
            return string.Format("SELECT VIEW_DEFINITION FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = '{0}';",
                                 viewName);
        }

        protected override string AllTableNamesLikeQuery(string pattern)
        {
            return
                string.Format(
                    "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{0}' and TABLE_NAME like upper('{1}') order by TABLE_NAME;",
                    ConnectionDetail.InitialCatalog, pattern);
        }

        protected override string AllProcsQueryForGivenPkg(string pkgName)
        {
            throw new NotImplementedException();
        }

        protected override string QueryForPkgHeader(string pkgName)
        {
            throw new NotImplementedException();
        }

        protected override string QueryForPkgBody(string pkgName)
        {
            throw new NotImplementedException();
        }

        public override void OpenConnection()
        {
            if (DbConnection != null) return;
            var stringBuilder = ConstructConnectionStringBuilder();
            DbConnection = new MySqlConnection(stringBuilder.ConnectionString);
            DbConnection.Open();
        }

        private DbConnectionStringBuilder ConstructConnectionStringBuilder()
        {
            return new MySqlConnectionStringBuilder
                       {
                           Server = ConnectionDetail.DataSourceName,
                           UserID = ConnectionDetail.UserName,
                           Password = ConnectionDetail.PassWord,
                           Database = ConnectionDetail.InitialCatalog
                       };
        }
    }
}