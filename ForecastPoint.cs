namespace FPP_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ForecastPoint
    {
        public long ID { get; set; }
         
        public DateTime? ForecastDate { get; set; }

        public int? Temperature { get; set; }

        public int? Huminity { get; set; }

        public double? Air { get; set; }

        public double? Extra1 { get; set; }

        public double? Extra2 { get; set; }

        public double? Extra3 { get; set; }

        public double? Points { get; set; }
    }
}
