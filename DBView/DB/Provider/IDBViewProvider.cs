using System.Collections.Generic;
using System.Data.Common;
using DBView.DTO;

namespace DBView.DB.Provider
{
    public interface IDBViewProvider
    {
        List<string> AllTableNames { get; }
        List<string> AllPackageNames { get; }
        List<string> AllViewNames { get; }

        List<string> RetreiveAllTableNamesLike(string pattern);
        List<string> RetreiveAllColumnNamesForGivenTable(string tableName);
        List<string> RetreiveAllKeyColumnsForGivenTable(string tableName);
        List<string> RetreiveAllConstraintsForGivenTable(string tableName);
        List<string> RetreiveAllTriggersForGivenTable(string tableName);
        List<string> RetreiveAllIndexesForGivenTable(string tableName);
        List<string> RetreiveAllProcNamesForGivenPkg(string pkgName);

        void OpenConnection();
        DbConnection DbConnection { get; }
        ConnectionDetail ConnectionDetail { get; }
        DBViewDataTable ExecuteQuery(string query);
        void Close();
        string RetreivePackageHeader(string pkgName);
        string RetreivePackageBody(string pkgName);
        string RetreiveViewBody(string viewName);
        void ResetContents();
        long ExecuteCountQuery(string countQuery);
    }
}