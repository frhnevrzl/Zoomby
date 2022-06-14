using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZoomScheduler.Master.Models
{
    [Table("TB_M_Zoom")]
    public class Zoom : Base
    {
        public int ZoomId { get; set; }
        public string ZoomName { get; set; }
    }
}