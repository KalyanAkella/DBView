using System.Windows.Forms;

namespace DBView.Controls
{
    public class ContextMenuItem
    {
        public static ToolStripMenuItem Connect(bool enabled)
        {
            return new ToolStripMenuItem
                       {
                           Name = "connectMenuItem",
                           ShowShortcutKeys = false,
                           Text = "&Connect",
                           ToolTipText = "Connect to this data source",
                           Enabled = enabled
                       };
        }

        public static ToolStripMenuItem Disconnect(bool enabled)
        {
            return new ToolStripMenuItem
                       {
                           Name = "disconnectMenuItem",
                           ShowShortcutKeys = false,
                           Text = "&Disconnect",
                           ToolTipText = "Disconnect this data source",
                           Enabled = enabled
                       };
        }

        public static ToolStripMenuItem Refresh(bool enabled)
        {
            return new ToolStripMenuItem
                       {
                           Name = "refreshMenuItem",
                           ShowShortcutKeys = false,
                           Text = "&Refresh Connection",
                           ToolTipText = "Refresh the contents of this item",
                           Enabled = enabled
                       };
        }

        public static ToolStripMenuItem Delete(bool enabled)
        {
            return new ToolStripMenuItem
                       {
                           Name = "deleteMenuItem",
                           ShowShortcutKeys = false,
                           Text = "&Delete Connection",
                           ToolTipText = "Delete this connection",
                           Enabled = enabled
                       };
        }

        public static ToolStripMenuItem NewConnection()
        {
            return new ToolStripMenuItem
                       {
                           Name = "newConnectionMenuItem",
                           ShowShortcutKeys = false,
                           Text = "&New Connection",
                           ToolTipText = "Add a new connection",
                       };
        }

        public static ToolStripMenuItem OpenTable()
        {
            return new ToolStripMenuItem
            {
                Name = "openTableMenuItem",
                ShowShortcutKeys = false,
                Text = "&Open Table",
                ToolTipText = "Open the contents of this table for editing",
            };
        }

        public static ToolStripMenuItem OpenPackageHeader()
        {
            return new ToolStripMenuItem
            {
                Name = "openPkgHdrMenuItem",
                ShowShortcutKeys = false,
                Text = "Open Package &Header",
                ToolTipText = "Retrieve the contents of this package header",
            };
        }

        public static ToolStripMenuItem OpenPackageBody()
        {
            return new ToolStripMenuItem
            {
                Name = "openPkgBdyMenuItem",
                ShowShortcutKeys = false,
                Text = "Open Package &Body",
                ToolTipText = "Retrieve the contents of this package body",
            };
        }

        public static ToolStripMenuItem OpenView()
        {
            return new ToolStripMenuItem
            {
                Name = "openViewMenuItem",
                ShowShortcutKeys = false,
                Text = "&Open View",
                ToolTipText = "Retrieve the contents of this view",
            };
        }

        public static ToolStripMenuItem OpenProcedure()
        {
            return new ToolStripMenuItem
            {
                Name = "openProcMenuItem",
                ShowShortcutKeys = false,
                Text = "&Open Procedure",
                ToolTipText = "Retrieve the contents of this procedure",
            };
        }
    }
}