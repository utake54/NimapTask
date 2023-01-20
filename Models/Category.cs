using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2Crud.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Category required")]
        public string category { get; set; }

        [Required(ErrorMessage ="Required")]
        public string item { get; set; }

        [Required(ErrorMessage ="Reuiured")]
        public string description { get; set; }
    }
}