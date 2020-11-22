﻿using System;
using System.Text.Json.Serialization;

namespace AspNetCore.Mvc.Extensions.Dtos
{
    public class PagingInfoDto
    {
        public int Page { get; set; }

        public int PageSize
        { get; set; }

        [JsonIgnore]
        public int TotalItems
        {
            get { return Records; }
            set { Records = value; }
        }

        public int Records { get; set; }

        public int Total => Pages;

        public string Search
        { get; set; }

        public string OrderBy
        { get; set; }

        public string PreviousPageLink
        { get; set; }

        public string NextPageLink
        { get; set; }

        public bool HasPrevious => (Page > 1);

        public bool HasNext => (Page < Total);

        [JsonIgnore]
        public int Pages
        {
            get
            {
                return Math.Max((int)Math.Ceiling(Convert.ToDouble(Records) / PageSize), 0);
            }
        }
    }
}
