using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotoApi.Models
{
    public class Sonuclar
    {

        [JsonProperty("haneSayisi")]
        public int haneSayisi { get; set; }

        [JsonProperty("tip")]
        public string tip { get; set; }

        [JsonProperty("ikramiye")]
        public int ikramiye { get; set; }

        [JsonProperty("numaralar")]
        public IList<string> numaralar { get; set; }
    }

    public class BuyukIkrKazananIlIlceler
    {

        [JsonProperty("il")]
        public string il { get; set; }

        [JsonProperty("ilView")]
        public string ilView { get; set; }

        [JsonProperty("ilce")]
        public string ilce { get; set; }

        [JsonProperty("ilceView")]
        public string ilceView { get; set; }
    }

    public class PiyangoModel
    {

        [JsonProperty("cekilisAdi")]
        public string cekilisAdi { get; set; }

        [JsonProperty("cekilisTarihi")]
        public string cekilisTarihi { get; set; }

        [JsonProperty("haneSayisi")]
        public int haneSayisi { get; set; }

        [JsonProperty("sonuclar")]
        public IList<Sonuclar> sonuclar { get; set; }

        [JsonProperty("buyukIkrKazananIlIlceler")]
        public IList<BuyukIkrKazananIlIlceler> buyukIkrKazananIlIlceler { get; set; }
    }
}