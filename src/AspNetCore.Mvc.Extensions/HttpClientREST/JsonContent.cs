using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace GrabMobile.ApiClient.HttpClientREST
{
    public class JsonContent : StringContent
    {
        public JsonContent(object value, JsonSerializerOptions serializerOptions)
           : base(JsonSerializer.Serialize(value, serializerOptions), Encoding.UTF8, "application/json")
        {
        }

        public JsonContent(object value)
            : base(JsonSerializer.Serialize(value, new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
            }), Encoding.UTF8, "application/json")
        {
        }

        public JsonContent(object value, string mediaType)
            : base(JsonSerializer.Serialize(value, new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DictionaryKeyPolicy= JsonNamingPolicy.CamelCase
            }), Encoding.UTF8, mediaType)
        {
        }
    }
}
