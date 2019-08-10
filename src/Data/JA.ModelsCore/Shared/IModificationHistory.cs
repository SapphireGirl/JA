using System;
using System.Collections.Generic;
using System.Text;

namespace JA.ModelsCore.Shared
{
    public interface IModificationHistory
    {
        DateTime DateModified { get; set; }
        DateTime DateCreated { get; set; }
        bool IsDirty { get; set; }
    }
}
