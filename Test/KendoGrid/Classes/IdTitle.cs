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
        public long Description { get { return Title.Length; } }
    }
}