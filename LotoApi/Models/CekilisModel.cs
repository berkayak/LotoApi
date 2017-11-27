using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotoApi.Models
{
    public class BilenKisiler
    {

        [JsonProperty("oid")]
        public string oid { get; set; }

        [JsonProperty("kisiBasinaDusenIkramiye")]
        public double kisiBasinaDusenIkramiye { get; set; }

        [JsonProperty("kisiSayisi")]
        public int kisiSayisi { get; set; }

        [JsonProperty("tur")]
        public string tur { get; set; }
    }

    public class Data
    {

        [JsonProperty("oid")]
        public string oid { get; set; }

        [JsonProperty("hafta")]
        public int hafta { get; set; }

        [JsonProperty("buyukIkramiyeKazananIl")]
        public string buyukIkramiyeKazananIl { get; set; }

        [JsonProperty("cekilisTarihi")]
        public string cekilisTarihi { get; set; }

        [JsonProperty("cekilisTuru")]
        public string cekilisTuru { get; set; }

        [JsonProperty("rakamlar")]
        public string rakamlar { get; set; }

        [JsonProperty("rakamlarNumaraSirasi")]
        public string rakamlarNumaraSirasi { get; set; }

        [JsonProperty("devretti")]
        public bool devretti { get; set; }

        [JsonProperty("devirSayisi")]
        public int devirSayisi { get; set; }

        [JsonProperty("bilenKisiler")]
        public IList<BilenKisiler> bilenKisiler { get; set; }

        [JsonProperty("buyukIkrKazananIlIlceler")]
        public IList<object> buyukIkrKazananIlIlceler { get; set; }

        [JsonProperty("kibrisHasilati")]
        public double kibrisHasilati { get; set; }

        [JsonProperty("devirTutari")]
        public int devirTutari { get; set; }

        [JsonProperty("kolonSayisi")]
        public int kolonSayisi { get; set; }

        [JsonProperty("kdv")]
        public double kdv { get; set; }

        [JsonProperty("toplamHasilat")]
        public double toplamHasilat { get; set; }

        [JsonProperty("hasilat")]
        public double hasilat { get; set; }

        [JsonProperty("sov")]
        public double sov { get; set; }

        [JsonProperty("ikramiyeEH")]
        public double ikramiyeEH { get; set; }

        [JsonProperty("buyukIkramiye")]
        public double buyukIkramiye { get; set; }

        [JsonProperty("haftayaDevredenTutar")]
        public double haftayaDevredenTutar { get; set; }
    }

    public class LotoCekilisModel
    {

        [JsonProperty("success")]
        public bool success { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }
    }
}