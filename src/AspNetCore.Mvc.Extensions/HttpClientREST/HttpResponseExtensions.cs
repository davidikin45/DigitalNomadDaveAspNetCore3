using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.HttpClientREST;
using AspNetCore.Mvc.Extensions.Json;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;


namespace GrabMobile.ApiClient.HttpClientREST
{
    public static class HttpResponseExtensions
    {
        public static async Task<T> ContentAsTypeAsync<T>(this HttpResponseMessage response, JsonSerializerOptions serializerOptions = null)
        {
            var data = await response.Content.ReadAsStringAsync();

            return string.IsNullOrEmpty(data) ?
                            default(T) :
                            JsonSerializer.Deserialize<T>(data, serializerOptions ?? new JsonSerializerOptions()
                            {
                                WriteIndented = true,
                                PropertyNameCaseInsensitive = true,
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
                            });
        }

        public static async Task<T> ContentAsTypeStreamAsync<T>(this HttpResponseMessage response, JsonSerializerOptions serializerOptions = null)
        {
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                return await JsonSerializer.DeserializeAsync<T>(stream, serializerOptions ?? new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
                });
            }
        }

        public static async Task<T> ContentAsTypeStreamNewtonsoftAsync<T>(this HttpResponseMessage response)
        {
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                using (var sr = new StreamReader(stream))
                {
                    using (var tr = new Newtonsoft.Json.JsonTextReader(sr))
                    {
                        var serializer = new Newtonsoft.Json.JsonSerializer();
                        return serializer.Deserialize<T>(tr);
                    }
                }
            }
        }

        public static async Task<dynamic> ContentAsDynamicAsync(this HttpResponseMessage response, JsonSerializerOptions serializerOptions = null)
        {
            var data = await response.Content.ReadAsStringAsync();

            var jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.PropertyNameCaseInsensitive = true;
            jsonSerializerOptions.WriteIndented = true;
            jsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            jsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
            jsonSerializerOptions.Converters.Add(new DynamicObjectConverter());

            return serializerOptions != null ? JsonSerializer.Deserialize<dynamic>(data, serializerOptions) : JsonSerializer.Deserialize<dynamic>(data, jsonSerializerOptions);
        }

        public static async Task<string> ContentAsStringAsync(this HttpResponseMessage response)
        {
            var data = await response.Content.ReadAsStringAsync();

            return data;
        }

        //https://stackoverflow.com/questions/21097730/usage-of-ensuresuccessstatuscode-and-handling-of-httprequestexception-it-throws
        public static async Task EnsureSuccessStatusCodeAsync(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return;
            }

            var content = await response.Content.ReadAsStringAsync();

            if (response.Content != null)
                response.Content.Dispose();

            throw new SimpleHttpResponseException((int)response.StatusCode, response.ReasonPhrase, content);
        }

        //https://stackoverflow.com/questions/21097730/usage-of-ensuresuccessstatuscode-and-handling-of-httprequestexception-it-throws
        public static void EnsureSuccessStatusCode(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return;
            }

            var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            if (response.Content != null)
                response.Content.Dispose();

            throw new SimpleHttpResponseException((int)response.StatusCode, response.ReasonPhrase, content);
        }

        public static PagingInfoDto FindAndParsePagingInfo(this HttpResponseHeaders responseHeaders)
        {
            // find the "X-Pagination" info in header
            if (responseHeaders.Contains("X-Pagination"))
            {
                var xPag = responseHeaders.First(ph => ph.Key == "X-Pagination").Value;

                // parse the value - this is a JSON-string.
                return JsonSerializer.Deserialize<PagingInfoDto>(xPag.First(), new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
                });
            }
            return null;
        }


    }
}
