using AspNetCore.Mvc.Extensions;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace DND.Web
{
    public class Program : ProgramBase<Startup>
    {
        public static Task<int> Main(string[] args)
        {
            return RunApp(args);
        }

        //Required for WebApplicationFactory
        public static new IHostBuilder CreateHostBuilder(string[] args)
        {
            return ProgramBase<Startup>.CreateHostBuilder(args);
        }
    }
}
