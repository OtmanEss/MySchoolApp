﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(School.WebUI.Startup))]
namespace School.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
