namespace ProjectSWT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CateSpecialization")]
    public partial class CateSpecialization
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Images { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public string Title { get; set; }
    }
}
