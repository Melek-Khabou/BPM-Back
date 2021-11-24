using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Employee
    {[Key]
        public int EmployeeID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Client{ get; set; }
        public int Salary { get; set; }
    }
}
