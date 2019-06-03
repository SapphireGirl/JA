using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JA.API.Providers
{
    public class JAProvider : IJAProvider
    {
        public string GetEC2InstanceId(string Name)
        {
            return "Virginia-East-1a";
        }
    }
}