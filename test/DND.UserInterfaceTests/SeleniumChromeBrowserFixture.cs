
using AspNetCore.Testing;
using AspNetCore.Testing.Selenium;
using DND.UserInterfaceTests;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DND.UserInterfaceTests
{
    public class SeleniumChromeBrowserFixture : SeleniumChromeBrowserFixtureBase, IDisposable
    {
        public SeleniumChromeBrowserFixture()
            : base(TestHelper.GetConfiguration().GetValue<string>("SeleniumUrl"), TestHelper.GetConfiguration().GetValue<bool>("HideBrowser"))
        {

        }
    }
}
