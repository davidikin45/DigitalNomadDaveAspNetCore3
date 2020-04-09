using AspNetCore.Testing;
using AspNetCore.Testing.DotNetRun;
using DND.UserInterfaceTests;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Reflection;
using Xunit;

namespace DND.UserInterfaceTests
{
    public class DotNetRunFixture : DotNetRunFixtureBase, IDisposable
    {
        public DotNetRunFixture()
            : base(TestHelper.GetConfiguration().GetValue<string>("CsProjPath"), TestHelper.GetConfiguration().GetValue<string>("Environment"), TestHelper.GetConfiguration().GetValue<string>("SeleniumUrl"), TestHelper.GetConfiguration().GetValue<bool>("HideBrowser"))
        {
            Launch();
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }

    [CollectionDefinition("DotNetRunFixture")]
    public class DotNetRunFixtureCollection : ICollectionFixture<DotNetRunFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
