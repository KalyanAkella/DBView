﻿using System.Collections.Generic;
using System.Windows.Forms;
using DBView.DB.Provider;

namespace DBView.Controls.Tree.Node
{
    public class IndexesNode : AbstractDBNode
    {
        public IndexesNode() : base("Indexes", NodeType.TABLE_INDEXES)
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
            return dbViewProvider.RetreiveAllIndexesForGivenTable(Parent.Text);
        }

        public override void FinishExpand(List<string> childNodeNames)
        {
            base.FinishExpand(childNodeNames);
            childNodeNames.ForEach(childNodeName => Nodes.Add(new IndexNode(childNodeName)));
        }
    }
}
