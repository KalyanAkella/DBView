namespace DBView.Controls.Tree.Node
{
    public class TriggerNode : AbstractDBNode
    {
        public TriggerNode(string text) : base(text, NodeType.TRIGGER)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }
    }
}