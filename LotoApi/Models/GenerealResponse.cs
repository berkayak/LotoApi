using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotoApi.Models
{
    public class GeneralResponse<T> where T : class
    {
        public bool isSuccess { get; set; }
        public T result { get; set; }


    }
}