namespace FPP_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fire")]
    public partial class Fire
    {
        public long ID { get; set; }

        [StringLength(20)]
        public string Lan { get; set; } 

        [StringLength(20)]
        public string Lng { get; set; }

        public decimal? HR { get; set; }

        public long ReasonID { get; set; }

        public DateTime Date { get; set; }
    }
}
