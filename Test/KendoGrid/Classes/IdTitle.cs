using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoGrid
{
    public class IdTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class DescriptionTitle : IdTitle
    {
        public string Description { get; set; }
        public string ShortDescription { get; set; }
    }
}