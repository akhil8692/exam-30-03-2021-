using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace exam.Models
{
    public class exammodel
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="this fiels cannot be empty")]
        public string description { get; set; }
        [Required(ErrorMessage ="this field cannot be empty")]
        public bool isdone { get; set; }
    }
}
