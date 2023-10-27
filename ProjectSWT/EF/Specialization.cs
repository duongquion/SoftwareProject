namespace ProjectSWT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specialization
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Images { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }

        public long? CateID { get; set; }
    }
}
