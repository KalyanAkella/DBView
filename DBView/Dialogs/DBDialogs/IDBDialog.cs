using System;
using DBView.DTO;

namespace DBView.Dialogs.DBDialogs
{
    public interface IDBDialog
    {
        ConnectionDetail ConnectionDetail { get; }
        event EventHandler DataAvailable;
        event EventHandler DataUnAvailable;
    }
}