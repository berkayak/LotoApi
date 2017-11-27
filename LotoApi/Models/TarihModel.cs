using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotoApi.Models
{
    public class TarihModel
    {
        [JsonProperty("tarih")]
        public string tarih { get; set; }

        [JsonProperty("tarihView")]
        public string tarihView { get; set; }
    }

}