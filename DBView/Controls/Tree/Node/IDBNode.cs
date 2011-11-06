using System.Collections.Generic;
using System.Windows.Forms;
using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public interface IDBNode
    {
        bool HasDBNodesAsChildren { get; }
        bool FindNext(FindDetails findDetails);
        bool DoesNodeMatch(FindDetails findDetails);
        bool FindPrevious(FindDetails findDetails);
        void BeginExpand();
        List<string> ProcessExpand();
        void FinishExpand(List<string> childNodeNames);
        bool UpdateContextMenu(ContextMenuStrip contextMenuStrip);
    }
}