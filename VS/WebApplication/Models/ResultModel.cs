using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ResultModel
    {
        public string Name { get; set; }
        public string Activity { get; set; }
        public string Traffic { get; set; }
        public string Reviews { get; set; }
        public string Wind { get; set; }

        public string Temperature { get; set; }

        public string Sunrise { get; set; }

        public string Sunset { get; set; }
    }
}