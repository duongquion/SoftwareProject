namespace ProjectSWT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Program
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Images { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(250)]
        public string Country { get; set; }

        [StringLength(250)]
        public string Duration { get; set; }

        [StringLength(250)]
        public string Requirement { get; set; }

        public decimal? Prices { get; set; }

        public long? CateID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }
    }
}
