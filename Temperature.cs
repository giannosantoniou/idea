namespace FPP_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Temperature")]
    public partial class Temperature
    {
        public long ID { get; set; }

        public long? StationID { get; set; }

        public DateTime? Moment { get; set; }
         
        public decimal? Highest { get; set; }

        public decimal? Lowest { get; set; }

        public decimal? Average { get; set; }

        public decimal? Huminity { get; set; }

        public decimal? Precipitation { get; set; }

        public decimal? WindSpeed { get; set; }

        public decimal? Rain { get; set; }

        public decimal? RainTotal24HR { get; set; }
    }
}
