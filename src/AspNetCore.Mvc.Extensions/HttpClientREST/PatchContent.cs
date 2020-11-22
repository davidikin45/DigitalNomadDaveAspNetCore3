using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace GrabMobile.ApiClient.HttpClientREST
{
    public class PatchContent : StringContent
    {
        public PatchContent(object value, JsonSerializerOptions serializerOptions)
            : base(JsonSerializer.Serialize(value, serializerOptions), Encoding.UTF8, "application/json-patch+json")
        {
        }

        public PatchContent(object value)
            : base(JsonSerializer.Serialize(value, new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
            }), Encoding.UTF8, "application/json-patch+json")
        {
        }
    }
}
