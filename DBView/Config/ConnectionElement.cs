using System.Configuration;
using DBView.DTO;

namespace DBView.Config
{
    public class ConnectionElement : ConfigurationElement
    {
        public void FromConnectionDetail(ConnectionDetail connectionDetail)
        {
            ConnName = connectionDetail.ConnName;
            DataSourceName = connectionDetail.DataSourceName;
            DBType = connectionDetail.DBType;
            AuthType = connectionDetail.AuthType;
            Username = connectionDetail.UserName;
            Password = connectionDetail.PassWord;
            HostName = connectionDetail.HostName;
            PortNumber = connectionDetail.PortNumber;
            ServiceName = connectionDetail.ServiceName;
            InitialCatalog = connectionDetail.InitialCatalog;
        }

        public ConnectionDetail ToConnectionDetail()
        {
            return new ConnectionDetail
                       {
                           ConnName = ConnName,
                           DataSourceName = DataSourceName,
                           DBType = DBType,
                           AuthType = AuthType,
                           UserName = Username,
                           PassWord = Password,
                           HostName = HostName,
                           PortNumber = PortNumber,
                           ServiceName = ServiceName,
                           InitialCatalog = InitialCatalog
                       };
        }

        [ConfigurationProperty("DataSourceName", IsRequired = true)]
        public string DataSourceName
        {
            get { return (string) this["DataSourceName"]; }
            set { this["DataSourceName"] = value; }
        }

        [ConfigurationProperty("HostName", IsRequired = true)]
        public string HostName
        {
            get { return (string) this["HostName"]; }
            set { this["HostName"] = value; }
        }

        [ConfigurationProperty("PortNumber", IsRequired = true)]
        public int PortNumber
        {
            get { return (int) this["PortNumber"]; }
            set { this["PortNumber"] = value; }
        }

        [ConfigurationProperty("ServiceName", IsRequired = true)]
        public string ServiceName
        {
            get { return (string) this["ServiceName"]; }
            set { this["ServiceName"] = value; }
        }

        [ConfigurationProperty("InitialCatalog", IsRequired = true)]
        public string InitialCatalog
        {
            get { return (string) this["InitialCatalog"]; }
            set { this["InitialCatalog"] = value; }
        }

        [ConfigurationProperty("ConnectionName", IsRequired = true)]
        public string ConnName
        {
            get { return (string) this["ConnectionName"]; }
            set { this["ConnectionName"] = value; }
        }

        [ConfigurationProperty("DBType", IsRequired = true)]
        public DBType DBType
        {
            get { return (DBType) this["DBType"]; }
            set { this["DBType"] = value; }
        }

        [ConfigurationProperty("AuthType", IsRequired = true)]
        public AuthType AuthType
        {
            get { return (AuthType) this["AuthType"]; }
            set { this["AuthType"] = value; }
        }

        [ConfigurationProperty("UserName", IsRequired = true)]
        public string Username
        {
            get { return (string) this["UserName"]; }
            set { this["UserName"] = value; }
        }

        [ConfigurationProperty("Password", IsRequired = true)]
        public string Password
        {
            get { return (string) this["Password"]; }
            set { this["Password"] = value; }
        }
    }
}