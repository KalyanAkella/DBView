using System.Collections.Generic;
using System.Data.Common;
using DBView.DB;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace IntegrationTest
{
    [TestFixture]
    public class MySqlConnectionTest
    {
        private const string ALL_TABLES_QUERY = "select table_name from information_schema.tables;";

        [Test]
        public void Connection()
        {
            var connectionStringBuilder = new MySqlConnectionStringBuilder
                              {
                                  Server = "localhost",
                                  UserID = "root",
                                  Password = "password"
                              };
            DbConnection dbConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);
            
            var allTableNames = new List<string>();
            DBUtil.ExecuteQuery(dbConnection, ALL_TABLES_QUERY, reader => allTableNames.Add((string)reader[0]));
            Assert.That(allTableNames.Count, Is.EqualTo(51));
        }
    }
}
