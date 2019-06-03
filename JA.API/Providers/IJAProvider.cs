using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA.API.Providers
{
    public interface IJAProvider
    {
        string GetEC2InstanceId(string Name);

    }
}
