using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace AspNetCore.Mvc.Extensions.Services
{
    public class JsonNavigationService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly Dictionary<string, List<NavigationItem>> _navigations = new Dictionary<string, List<NavigationItem>>();
        private readonly JsonOptions _jsonOptions;

        public JsonNavigationService(IWebHostEnvironment hostingEnvironment, IOptions<JsonNavigationServiceOptions> options, IOptions<JsonOptions> jsonOptions)
        {
            _hostingEnvironment = hostingEnvironment;
            _jsonOptions = jsonOptions.Value;

            foreach (var file in options.Value.FileNames)
            {
                _navigations.Add(file, JsonSerializer.Deserialize<List<NavigationItem>>(File.ReadAllText(Path.Combine(_hostingEnvironment.ContentRootPath, file)), _jsonOptions.JsonSerializerOptions));
            }
        }

        public IEnumerable<NavigationItem> GetNavigation(string filename)
        {
            return _navigations[filename].Where(n => !n.Active.HasValue || n.Active.Value);
        }
    }

    public class JsonNavigationServiceOptions
    {
        public List<string> FileNames = new List<string>() { "navigation.json" };
    }

    public class NavigationItem
    {
        public bool? Active { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string LinkText { get; set; }
    }
}
