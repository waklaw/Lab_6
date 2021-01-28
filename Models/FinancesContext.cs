using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class FinancesContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<AddStudent> AddStudents { get; set; }
    }
}