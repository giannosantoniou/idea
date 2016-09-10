namespace FPP_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Station")]
    public partial class Station
    {
        public long ID { get; set; }

        [StringLength(100)] 
        public string Title { get; set; }

        public decimal? Lan { get; set; }

        public decimal? Lng { get; set; }

        public int? StationNo { get; set; }

        public int? Height { get; set; }

        public bool? isAutomatic { get; set; }

        public bool? isPrecipitation { get; set; }

        public bool? isGeneral { get; set; }

        [StringLength(50)]
        public string StationType { get; set; }
    }
}
