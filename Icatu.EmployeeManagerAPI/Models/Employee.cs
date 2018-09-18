using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Icatu.EmployeeManagerAPI.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Departamento")]
        public string Departamento { get; set; }
        
    }
}