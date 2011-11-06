using System.Configuration;

namespace DBView.Config
{
    public class ConnectionCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConnectionElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConnectionElement) element).ConnName;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.AddRemoveClearMap; }
        }

        public void Add(ConnectionElement connectionElement)
        {
            BaseAdd(connectionElement);
        }

        public void Clear()
        {
            BaseClear();
        }

        public void Remove(ConnectionElement connectionElement)
        {
            BaseRemove(connectionElement.ConnName);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }
    }
}