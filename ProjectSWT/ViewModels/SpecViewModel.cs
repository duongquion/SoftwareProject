using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSWT.ViewModels
{
    public class SpecViewModel
    {
        public long ID { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
    }
}