using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AspNetCore.Mvc.Extensions.ActionResults
{
    public class HtmlResult : ContentResult
    {
        public HtmlResult(string html)
        {
            Content = html;
            ContentType = "text/html";
            StatusCode = StatusCodes.Status200OK;
        }
    }
}
