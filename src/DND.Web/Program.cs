using AspNetCore.Mvc.Extensions;
using System.Threading.Tasks;

namespace DND.Web
{
    public class Program : ProgramBase<Startup>
    {
        public static Task<int> Main(string[] args)
        {
            return RunApp(args);
        }
    }
}
