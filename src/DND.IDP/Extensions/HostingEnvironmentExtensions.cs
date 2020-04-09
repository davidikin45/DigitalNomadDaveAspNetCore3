using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DND.IDP.Extensions
{
    public static class HostingEnvironmentExtensions
    {
        public static string MapContentPath(this IHostingEnvironment hostingEnvironement, string path)
        {
            var result = path ?? string.Empty;
            if (hostingEnvironement.IsContentPathMapped(path) == false)
            {
                var contentRoot = hostingEnvironement.ContentRootPath;
                if (result.StartsWith("~", StringComparison.Ordinal))
                {
                    result = result.Substring(1);
                }
                if (result.StartsWith("/", StringComparison.Ordinal))
                {
                    result = result.Substring(1);
                }
                result = Path.Combine(contentRoot, result.Replace('/', '\\'));
            }

            return result;
        }

        public static bool IsContentPathMapped(this IHostingEnvironment hostingEnvironement, string path)
        {
            var result = path ?? string.Empty;
            return result.StartsWith(hostingEnvironement.ContentRootPath,
                StringComparison.Ordinal);
        }
    }
}
