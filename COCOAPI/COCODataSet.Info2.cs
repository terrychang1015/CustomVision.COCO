﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace COCOAPI
{

    internal partial class COCODataSet
    {
        internal class Info2
        {

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("year")]
            public int Year { get; set; }

            [JsonProperty("contributor")]
            public string Contributor { get; set; }

            [JsonProperty("date_created")]
            public string DateCreated { get; set; }
        }
    }

}
