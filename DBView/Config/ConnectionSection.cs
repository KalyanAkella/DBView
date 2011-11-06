using System.Configuration;

namespace DBView.Config
{
    public class ConnectionSection : ConfigurationSection
    {
        [ConfigurationCollection(typeof(ConnectionCollection))]
        [ConfigurationProperty("Connections", IsDefaultCollection = false)]
        public ConnectionCollection Connections
        {
            get { return this["Connections"] as ConnectionCollection; }
        }
    }
}