namespace DBView.DTO
{
    public enum DBType
    {
        Oracle,
        MySql,
		SqlServer
    }

    public enum AuthType
    {
        Windows, Database
    }

    public class ConnectionDetail
    {
        public string DataSourceName { get; set; }

        public string HostName { get; set; }

        public int PortNumber { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public DBType DBType { get; set; }
        
        public AuthType AuthType { get; set; }

        public string ConnName { get; set; }

        public string InitialCatalog { get; set; }

        public string ServiceName { get; set; }
    }
}
