using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.ResponseModels
{
    public class Response
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public dynamic data { get; set; }
    }
}
