namespace ProjectSWT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Level")]
    public partial class Level
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
    }
}
