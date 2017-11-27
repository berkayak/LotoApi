using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LotoApi.Models;
using LotoApi.Helpers;
using Newtonsoft.Json;

namespace LotoApi.Controllers
{
    public class SansOyunlariController : ApiController
    {
        /// <summary>
        /// Oyun türüne göre tarihleri getirir
        /// </summary>
        /// <param name="oyunTuru"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        public GeneralResponse<List<TarihModel>> Tarihler(string oyunTuru, int count = int.MaxValue)
        {
            
            GeneralResponse<List<TarihModel>> response = new GeneralResponse<List<TarihModel>>();
            if(string.Empty == isValidType(oyunTuru))
            {
                response.isSuccess = false;
                response.result = null;
                return response;
            }
            string dataLink = String.Format(Constants.tarihLink, oyunTuru);

            try
            {
                response.result = JsonConvert.DeserializeObject<List<TarihModel>>(getDataFromLink(dataLink)).Take(count).ToList();
                response.isSuccess = true;
            }
            catch
            {
                response.isSuccess = false;
                response.result = null;                                               
            }

            return response;
        }

        /// <summary>
        /// tarih ve oyun parametresine göre çeklişi sonuçlarını getirir. 
        /// Milli piyango için overload edilmiş halini kullanın
        /// </summary>
        /// <param name="tarih"></param>
        /// <param name="oyunTuru"></param>
        /// <returns></returns>
        [HttpGet]
        public GeneralResponse<Data> Cekilis(string tarih, string oyunTuru)
        {
            GeneralResponse<Data> response = new GeneralResponse<Data>();
            if (isValidType(oyunTuru) == String.Empty)
            {
                response.isSuccess = false;
                response.result = null;
                return response;
            }
            string dataLink = String.Format(Constants.cekilisLink, oyunTuru, tarih);
            try
            {
                response.result = JsonConvert.DeserializeObject<LotoCekilisModel>(getDataFromLink(dataLink)).data;
                response.isSuccess = true;                 
            }
            catch
            {
                response.isSuccess = false;
                response.result = null;
            }

            return response;
        }

        /// <summary>
        /// Milli piyango sonucları için overload edilmiş method
        /// </summary>
        /// <param name="tarih"></param>
        /// <returns></returns>
        [HttpGet]
        public GeneralResponse<PiyangoModel> Cekilis(string tarih)
        {
            GeneralResponse<PiyangoModel> response = new GeneralResponse<PiyangoModel>();
            string dataLink = String.Format(Constants.cekilisLink, Constants.LotoTipleri.piyango.ToString(), tarih);

            try
            {
                response.result = JsonConvert.DeserializeObject<PiyangoModel>(getDataFromLink(dataLink));
                response.isSuccess = true;
            }
            catch
            {
                response.isSuccess = false;
                response.result = null;
            }

            return response;

        }

        private string getDataFromLink(string dataLink)
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            return  wc.DownloadString(dataLink);
        }


        private string isValidType(string oyunID)
        {
            if (oyunID == Constants.LotoTipleri.sayisal.ToString()) return Constants.LotoTipleri.sayisal.ToString();
            else if (oyunID == Constants.LotoTipleri.sanstopu.ToString()) return Constants.LotoTipleri.sanstopu.ToString();
            else if (oyunID == Constants.LotoTipleri.onnumara.ToString()) return Constants.LotoTipleri.onnumara.ToString();
            else if (oyunID == Constants.LotoTipleri.superloto.ToString()) return Constants.LotoTipleri.superloto.ToString();
            else if (oyunID == Constants.LotoTipleri.piyango.ToString()) return Constants.LotoTipleri.piyango.ToString();
            else return string.Empty;
        }
    }
}
