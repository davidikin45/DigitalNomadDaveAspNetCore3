using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace AspNetCore.Testing.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static void AssertOk(this HttpResponseMessage response)
        {
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
