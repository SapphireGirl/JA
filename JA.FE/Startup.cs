using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using JA.Data.Context;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(JA.FE.Startup))]

namespace JA.FE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Database.SetInitializer(new NullDatabaseInitializer<BlogContext>());
        }
    }
}
