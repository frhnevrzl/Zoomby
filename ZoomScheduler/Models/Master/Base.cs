using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZoomScheduler.Master.Models
{
    public class Base
    {
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDelete { get; set; }
    }
}