using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZoomScheduler.Master.Models
{
    [Table("TB_M_User")]
    public class User : Base
    {
        public int Id { get; set; }
        public string Nama { get; set; }
    }
}