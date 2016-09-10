namespace FPP_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StationOriginal")]
    public partial class StationOriginal
    {
        public long ID { get; set; }

        public int StationNo { get; set; }

        [StringLength(50)]
        public string StationName { get; set; } 

        public int? High { get; set; }

        [StringLength(15)]
        public string Platos { get; set; }

        [StringLength(15)]
        public string Mikos { get; set; }

        public decimal? Lan { get; set; }

        public decimal? Lng { get; set; }
    }
}
