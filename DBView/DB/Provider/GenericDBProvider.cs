using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBView.DTO;

namespace DBView.DB.Provider
{
    public abstract class GenericDBProvider : IDBViewProvider
    {
        private List<string> allTableNames;
        private List<string> allPackageNames;
        private List<string> allViewNames;

        public DbConnection DbConnection { get; protected set; }
        public ConnectionDetail ConnectionDetail { get; private set; }

        protected abstract string AllTablesQuery { get; }
        protected abstract string AllPackagesQuery { get; }
        protected abstract string AllViewsQuery { get; }
        protected abstract string AllColumnsQueryForGivenTable(string tableName);
        protected abstract string AllPrimaryKeyColumnsQueryForGivenTable(string tableName);
        protected abstract string AllForeignKeyColumnsQueryForGivenTable(string tableName);
        protected abstract string AllConstraintsQueryForGivenTable(string tableName);
        protected abstract string AllTriggersQueryForGivenTable(string tableName);
        protected abstract string AllIndexesQueryForGivenTable(string tableName);
        protected abstract string AllProcsQueryForGivenPkg(string pkgName);
        protected abstract string QueryForPkgHeader(string pkgName);
        protected abstract string QueryForPkgBody(string pkgName);
        protected abstract string QueryForViewBody(string viewName);
        protected abstract string AllTableNamesLikeQuery(string pattern);

        protected GenericDBProvider(ConnectionDetail connectionDetail)
        {
            ConnectionDetail = connectionDetail;
        }

        public List<string> AllTableNames
        {
            get
            {
                if (allTableNames == null) allTableNames = RetreiveAllTableNames();
                return allTableNames;
            }
        }

        public List<string> AllPackageNames
        {
            get
            {
                if (allPackageNames == null) allPackageNames = RetreiveAllPackageNames();
                return allPackageNames;
            }
        }

        public List<string> AllViewNames
        {
            get
            {
                if (allViewNames == null) allViewNames = RetreiveAllViewNames();
                return allViewNames;
            }
        }

        private List<string> RetreiveAllViewNames()
        {
            var _allViewNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllViewsQuery, reader => _allViewNames.Add((string) reader[0]));
            return _allViewNames;
        }

        private List<string> RetreiveAllPackageNames()
        {
            var _allPackageNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllPackagesQuery, reader => _allPackageNames.Add((string) reader[0]));
            return _allPackageNames;
        }

        public long ExecuteCountQuery(string countQuery)
        {
            return DBUtil.ExecuteCountQuery(DbConnection, countQuery);
        }

        public DBViewDataTable ExecuteQuery(string query)
        {
            return DBUtil.ExecuteQuery(DbConnection, query);
        }

        public List<string> RetreiveAllColumnNamesForGivenTable(string tableName)
        {
            var allColumnNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllColumnsQueryForGivenTable(tableName),
                                reader => allColumnNames.Add((string) reader[0]));
            return allColumnNames;
        }

        public List<string> RetreiveAllKeyColumnsForGivenTable(string tableName)
        {
            var allKeyColumnNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllPrimaryKeyColumnsQueryForGivenTable(tableName),
                                reader => allKeyColumnNames.Add((string) reader[0]));
            DBUtil.ExecuteQuery(DbConnection, AllForeignKeyColumnsQueryForGivenTable(tableName),
                                reader => allKeyColumnNames.Add((string) reader[0]));
            return allKeyColumnNames;
        }

        public List<string> RetreiveAllConstraintsForGivenTable(string tableName)
        {
            var allConstraintNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllConstraintsQueryForGivenTable(tableName),
                                reader => allConstraintNames.Add((string) reader[0]));
            return allConstraintNames;
        }

        public List<string> RetreiveAllTriggersForGivenTable(string tableName)
        {
            var allTriggerNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllTriggersQueryForGivenTable(tableName),
                                reader => allTriggerNames.Add((string) reader[0]));
            return allTriggerNames;
        }

        public List<string> RetreiveAllIndexesForGivenTable(string tableName)
        {
            var allIndexNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllIndexesQueryForGivenTable(tableName),
                                reader => allIndexNames.Add((string) reader[0]));
            return allIndexNames;
        }

        public virtual List<string> RetreiveAllProcNamesForGivenPkg(string pkgName)
        {
            var allProcName = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllProcsQueryForGivenPkg(pkgName),
                                reader => allProcName.Add((string) reader[0]));
            return allProcName;
        }

        public string RetreivePackageHeader(string pkgName)
        {
            var buffer = new StringBuilder();
            DBUtil.ExecuteQuery(DbConnection, QueryForPkgHeader(pkgName), reader => buffer.Append((string) reader[0]));
            return buffer.ToString();
        }

        public string RetreivePackageBody(string pkgName)
        {
            var buffer = new StringBuilder();
            DBUtil.ExecuteQuery(DbConnection, QueryForPkgBody(pkgName), reader => buffer.Append((string) reader[0]));
            return buffer.ToString();
        }

        public string RetreiveViewBody(string viewName)
        {
            var buffer = new StringBuilder();
            DBUtil.ExecuteQuery(DbConnection, QueryForViewBody(viewName), reader => buffer.Append((string) reader[0]));
            return buffer.ToString();
        }

        public List<string> RetreiveAllTableNamesLike(string pattern)
        {
            var taleNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllTableNamesLikeQuery(pattern),
                                reader => taleNames.Add((string) reader[0]));
            return taleNames;
        }

        public void ResetContents()
        {
            allTableNames = null;
            allPackageNames = null;
            allViewNames = null;
        }

        public void Close()
        {
            if (DbConnection != null && DbConnection.State != ConnectionState.Closed) DbConnection.Close();
        }

        private List<string> RetreiveAllTableNames()
        {
            var _allTableNames = new List<string>();
            DBUtil.ExecuteQuery(DbConnection, AllTablesQuery, reader => _allTableNames.Add((string) reader[0]));
            return _allTableNames;
        }

        public abstract void OpenConnection();
    }
}