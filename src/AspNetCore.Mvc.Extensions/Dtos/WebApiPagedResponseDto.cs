using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AspNetCore.Mvc.Extensions.Dtos
{
    public class WebApiPagedResponseDto<T> : PagingInfoDto
    {
        [JsonIgnore]
        public List<T> Data
        {
            get { return Rows; }
        }

        public List<T> Rows
        { get; set; }
    }
}
