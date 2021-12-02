using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        [ForeignKey("BUId")]
        public virtual BusinessUnit BU { get; set; }
    }
}
