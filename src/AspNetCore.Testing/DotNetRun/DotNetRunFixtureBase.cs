using AspNetCore.Testing.Processes;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.IO;

namespace AspNetCore.Testing.DotNetRun
{
    public abstract class DotNetRunFixtureBase : IDisposable
    {
        private SimpleProcess _process;
        private string _environment;
        private string _webAppPath;

        private string _url;
        private bool _hideBrowser;

        public DotNetRunFixtureBase(string csprojPath, string environment, string url, bool hideBrowser)
        {
            _webAppPath = csprojPath;
            _environment = environment;
            _hideBrowser = hideBrowser;
            _url = url;

            string filename = "dotnet.exe";
            string args = $@"run --project {csprojPath} environment={_environment} --no-build --urls ""{_url}""";

            _process = new SimpleProcess(filename, args, _hideBrowser);
        }

        public void Launch()
        {
            if (!string.IsNullOrEmpty(_webAppPath) && !string.IsNullOrEmpty(_environment) && _url.Contains("localhost"))
            {
                _process.StartProcess();
            }
        }

        //private string GetContentRootPath()
        //{
        //    var testProjectPath = Path.GetDirectoryName(this.GetType().Assembly.Location);
        //    var contentPath = Path.GetFullPath(Path.Combine(testProjectPath, _webAppRelativePath));
        //    return contentPath;
        //}

        public bool IsRunning
        {
            get
            {
                return _process.IsRunning;
            }
        }

        public void Dispose()
        {
            _process.Dispose();
        }
    }
}
