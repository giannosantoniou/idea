namespace FPP_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reason")]
    public partial class Reason
    {
        public long ID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }
         
        public bool? isNatural { get; set; }

        [StringLength(1)]
        public string Symbol { get; set; }
    }
}
