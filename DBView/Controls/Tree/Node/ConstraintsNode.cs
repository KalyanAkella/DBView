using System.Collections.Generic;
using System.Windows.Forms;
using DBView.DB.Provider;

namespace DBView.Controls.Tree.Node
{
    public class ConstraintsNode : AbstractDBNode
    {
        public ConstraintsNode() : base("Constraints", NodeType.TABLE_CONSTRAINTS)
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
            return dbViewProvider.RetreiveAllConstraintsForGivenTable(Parent.Text);
        }

        public override void FinishExpand(List<string> childNodeNames)
        {
            base.FinishExpand(childNodeNames);
            childNodeNames.ForEach(childNodeName => Nodes.Add(new ConstraintNode(childNodeName)));
        }
    }
}
