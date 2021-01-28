using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Group
    {
        [Key]
        public int Group_id { get; set; }
        [MaxLength(20)]
        public string GroupName { get; set; }
    }
}