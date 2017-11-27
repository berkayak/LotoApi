using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotoApi.Helpers
{
    public static class Constants
    {
        public const string tarihLink = "http://www.millipiyango.gov.tr/sonuclar/listCekilisleriTarihleri.php?tur={0}";
        public const string cekilisLink = "http://www.millipiyango.gov.tr/sonuclar/cekilisler/{0}/{1}.json";

        public enum LotoTipleri
        {
            sayisal = 1,
            sanstopu = 2,
            onnumara = 3,
            superloto = 4,
            piyango = 5,
        }
    }
}