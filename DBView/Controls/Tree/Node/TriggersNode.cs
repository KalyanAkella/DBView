using System.Collections.Generic;
using System.Windows.Forms;
using DBView.DB.Provider;

namespace DBView.Controls.Tree.Node
{
    public class TriggersNode : AbstractDBNode
    {
        public TriggersNode() : base("Triggers", NodeType.TABLE_TRIGGERS)
        {
            Nodes.Add(new TreeNode());
        }

        public override bool HasDBNodesAsChildren
        {
            get { return true; }
        }

        public override List<string> ProcessExpandSafely()
        {
            var dbViewProvider = (IDBViewProvider) Parent.Parent.Parent.Tag;
            return dbViewProvider.RetreiveAllTriggersForGivenTable(Parent.Text);
        }

        public override void FinishExpand(List<string> childNodeNames)
        {
            base.FinishExpand(childNodeNames);
            childNodeNames.ForEach(childNodeName => Nodes.Add(new TriggerNode(childNodeName)));
        }
    }
}
