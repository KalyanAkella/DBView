using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using DBView.Config;
using DBView.DTO;

namespace DBView.DB
{
    public static class DBUtil
    {
        public static void ExecuteQuery(DbConnection dbConnection, string query, Action<DbDataReader> forEveryRow)
        {
            DbCommand dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = query;
            DbDataReader reader = null;
            try
            {
                reader = dbCommand.ExecuteReader();
                while (reader.Read()) forEveryRow(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        public static long ExecuteCountQuery(DbConnection dbConnection, string countQuery)
        {
            decimal count = 0;
            ExecuteQuery(dbConnection, countQuery, reader => count = (decimal) reader[0]);
            return Decimal.ToInt64(count);
        }

        public static DBViewDataTable ExecuteQuery(DbConnection dbConnection, string query)
        {
            var dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = query;
            DbDataReader reader = null;
            var dbViewDataTable = new DBViewDataTable();
            try
            {
                reader = dbCommand.ExecuteReader();
                dbViewDataTable.DataTable.Load(reader, LoadOption.OverwriteChanges);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    dbViewDataTable.RecordsAffected = reader.RecordsAffected;
                }
            }
            return dbViewDataTable;
        }

        public static Array SupportedDBList()
        {
            return Enum.GetValues(typeof (DBType));
        }

        public static ConnectionDetail[] RecentConnections()
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionSection = (ConnectionSection) configuration.Sections["DBViewConnections"];
            if (connectionSection == null || connectionSection.Connections == null) return null;
            var connectionDetails = new ConnectionDetail[connectionSection.Connections.Count];
            var count = 0;
            foreach (ConnectionElement connection in connectionSection.Connections)
                connectionDetails[count++] = connection.ToConnectionDetail();
            return connectionDetails;
        }

        public static void SaveConnection(ConnectionDetail connectionDetail)
        {
            var connectionElement = new ConnectionElement();
            connectionElement.FromConnectionDetail(connectionDetail);

            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionsSection = (ConnectionSection) configuration.Sections["DBViewConnections"];
            if (connectionsSection != null)
                connectionsSection.Connections.Add(connectionElement);
            else
            {
                connectionsSection = new ConnectionSection();
                connectionsSection.Connections.Add(connectionElement);
                configuration.Sections.Add("DBViewConnections", connectionsSection);
            }
            connectionsSection.SectionInformation.ForceSave = true;
            configuration.Save(ConfigurationSaveMode.Full);
        }

        public static void DeleteConnection(ConnectionDetail connectionDetail)
        {
            var connectionElement = new ConnectionElement();
            connectionElement.FromConnectionDetail(connectionDetail);

            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionsSection = (ConnectionSection) configuration.Sections["DBViewConnections"];
            if (connectionsSection == null) return;
            connectionsSection.Connections.Remove(connectionElement);
            connectionsSection.SectionInformation.ForceSave = true;
            configuration.Save(ConfigurationSaveMode.Full);
        }
    }
}