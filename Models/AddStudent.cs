using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class AddStudent
    {
        [Key]
        public int Student_id {get;set;}
        public string NameGroup { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}