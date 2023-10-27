namespace ProjectSWT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Images { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(250)]
        public string Location { get; set; }

        public DateTime? Date { get; set; }

        public TimeSpan? Time { get; set; }

        public bool? Status { get; set; }
    }
}
