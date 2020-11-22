using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AspNetCore.Mvc.Extensions.Services
{
    public class BundleConfigService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly JsonOptions _jsonOptions;

        public BundleConfigService(IWebHostEnvironment hostingEnvironment, IOptions<JsonOptions> jsonOptions)
        {
            _hostingEnvironment = hostingEnvironment;
            _jsonOptions = jsonOptions.Value;
            Config = JsonSerializer.Deserialize<List<Bundle>>(File.ReadAllText(Path.Combine(_hostingEnvironment.ContentRootPath, "bundleconfig.json")), _jsonOptions.JsonSerializerOptions);
        }

        public List<Bundle> Config { get; }

        public Bundle Bundle(string outputFileName)
        {
            foreach (var bundle in Config)
            {
                if (bundle.OutputFileName == outputFileName)
                {
                    return bundle;
                }
            }

            throw new Exception("Bundle not found");
        }
    }

    public class Minify
    {
        public bool Enabled { get; set; }
        public bool RenameLocals { get; set; }
    }

    public class Bundle
    {
        public string OutputFileName { get; set; }
        public List<string> InputFiles { get; set; }
        public Minify Minify { get; set; }
        public bool? SourceMap { get; set; }
    }

}
//_CSS.cshml
//@inject BundleConfigService BundleConfigService
//<environment include="Development">
//    @foreach(string style in BundleConfigService.Bundle("wwwroot/css/third-party.min.css").inputFiles)
//    {
//        <link rel = "stylesheet" href="@style.Replace("wwwroot","~")" asp-append-version="true" />
//    }

//    @foreach(string style in BundleConfigService.Bundle("wwwroot/css/site.min.css").inputFiles)
//    {
//        <link rel = "stylesheet" href="@style.Replace("wwwroot","~")" asp-append-version="true" />
//    }
//</environment>
//<environment exclude = "Development" >
//    < link rel="stylesheet" href="~/css/third-party.min.css" asp-append-version="true" />
//    <link rel = "stylesheet" href="~/css/site.min.css" asp-append-version="true" />
//</environment>

//_JS.cshml
//@inject BundleConfigService BundleConfigService
//<environment include="Development">
//    @foreach(string script in BundleConfigService.Bundle("wwwroot/js/third-party.min.js").inputFiles)
//    {
//        <script src = "@script.Replace("wwwroot","~")" asp-append-version="true"></script>
//    }

//    @foreach(string script in BundleConfigService.Bundle("wwwroot/js/angular.app.min.js").inputFiles)
//    {
//        <script src = "@script.Replace("wwwroot","~")" asp-append-version="true"></script>
//    }

//    @foreach(string script in BundleConfigService.Bundle("wwwroot/js/site.min.js").inputFiles)
//    {
//        <script src = "@script.Replace("wwwroot","~")" asp-append-version="true"></script>
//    }
//</environment>
//<environment exclude = "Development" >
//    < script src="~/js/third-party.min.js" asp-append-version="true"></script>
//    <script src = "~/js/angular.app.min.js" asp-append-version="true"></script>
//    <script src = "~/js/site.min.js" asp-append-version="true"></script>
//</environment>