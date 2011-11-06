using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using DBView.DTO;

namespace DBView.DB.Provider
{
    public class SqlServerProvider : GenericDBProvider
    {
        public SqlServerProvider(ConnectionDetail connectionDetail) : base(connectionDetail)
        {
        }

        protected override string AllTablesQuery
        {
            get
            {
                return
                    string.Format(
                        "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG = '{0}' AND TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME;",
                        ConnectionDetail.InitialCatalog);
            }
        }

        protected override string AllPackagesQuery
        {
            get
            {
                return
                    string.Format(
                        "SELECT ROUTINE_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_CATALOG = '{0}' ORDER BY ROUTINE_NAME;",
                        ConnectionDetail.InitialCatalog);
            }
        }

        protected override string AllViewsQuery
        {
            get
            {
                return
                    string.Format(
                        "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_CATALOG = '{0}' ORDER BY TABLE_NAME;",
                        ConnectionDetail.InitialCatalog);
            }
        }

        protected override string AllColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_CATALOG = '{0}' AND TABLE_NAME='{1}';",
                    ConnectionDetail.InitialCatalog, tableName);
        }

        protected override string AllPrimaryKeyColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_CATALOG = '{0}' AND TABLE_NAME = '{1}' AND CONSTRAINT_TYPE = 'PRIMARY KEY';",
                    ConnectionDetail.InitialCatalog, tableName);
        }

        protected override string AllForeignKeyColumnsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_CATALOG = '{0}' AND TABLE_NAME = '{1}' AND CONSTRAINT_TYPE = 'FOREIGN KEY';",
                    ConnectionDetail.InitialCatalog, tableName);
        }

        protected override string AllConstraintsQueryForGivenTable(string tableName)
        {
            return
                string.Format(
                    "SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_CATALOG = '{0}' AND TABLE_NAME = '{1}' ORDER BY CONSTRAINT_NAME;",
                    ConnectionDetail.InitialCatalog, tableName);
        }

        protected override string AllTriggersQueryForGivenTable(string tableName)
        {
            return
                string.Format("SELECT * FROM SYS.TRIGGERS WHERE IS_MS_SHIPPED = 0 AND OBJECT_NAME(PARENT_ID) = '{0}';",
                              tableName);
        }

        protected override string AllIndexesQueryForGivenTable(string tableName)
        {
            return string.Format("SELECT NAME FROM SYSINDEXES WHERE OBJECT_NAME(ID) = '{0}';", tableName);
        }

        protected override string AllProcsQueryForGivenPkg(string pkgName)
        {
            throw new NotImplementedException();
        }

        protected override string QueryForPkgHeader(string pkgName)
        {
            return string.Format("SELECT ROUTINE_DEFINITION FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_NAME='{0}'",
                                 pkgName);
        }

        protected override string QueryForPkgBody(string pkgName)
        {
            throw new NotImplementedException();
        }

        protected override string QueryForViewBody(string viewName)
        {
            return string.Format("SELECT VIEW_DEFINITION FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = '{0}';",
                                 viewName);
        }

        protected override string AllTableNamesLikeQuery(string pattern)
        {
            return string.Format(
                "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG = '{0}' AND TABLE_TYPE='BASE TABLE' AND TABLE_NAME LIKE ('{1}') ORDER BY TABLE_NAME;",
                ConnectionDetail.InitialCatalog, pattern);
        }

        public override List<string> RetreiveAllProcNamesForGivenPkg(string pkgName)
        {
            return new List<string>();
        }

        public override void OpenConnection()
        {
            if (DbConnection != null) return;
            var stringBuilder = ConstructConnectionStringBuilder();
            DbConnection = new SqlConnection(stringBuilder.ConnectionString);
            DbConnection.Open();
        }

        private DbConnectionStringBuilder ConstructConnectionStringBuilder()
        {
            return ConnectionDetail.AuthType == AuthType.Windows
                       ?
                           new SqlConnectionStringBuilder
                               {
                                   DataSource = ConnectionDetail.DataSourceName,
                                   InitialCatalog = ConnectionDetail.InitialCatalog,
                                   IntegratedSecurity = true
                               }
                       :
                           new SqlConnectionStringBuilder
                               {
                                   DataSource = ConnectionDetail.DataSourceName,
                                   InitialCatalog = ConnectionDetail.InitialCatalog,
                                   IntegratedSecurity = false,
                                   UserID = ConnectionDetail.UserName,
                                   Password = ConnectionDetail.PassWord
                               };
        }
    }
}