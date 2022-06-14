using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ZoomScheduler.Master.Models;

namespace ZoomScheduler.Transaksi.Models
{
    [Table("TB_T_Scheduler")]
    public class Scheduler : Base
    {
        public User User { get; set; }
        public int UserId { get; set; }

        public Zoom Zoom { get; set; }
        public int ZoomId { get; set; }

        public int Id { get; set; }

        public DateTime TanggalPelaksanaan { get; set; }

        public string Link { get; set; }
        public string Aktivitas { get; set; }

        public bool IsDone { get; set; }

    }
}