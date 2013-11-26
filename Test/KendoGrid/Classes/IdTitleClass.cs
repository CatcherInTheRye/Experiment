using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KendoGrid
{
    public class IdTitle
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string Title { get; set; }
    }

    public class IdTitleDescription : IdTitle
    {
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Короткое описание")]
        public string ShortDescription { get; set; }
    }
}