using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace API.Models
{
    public class Registration : IdentityUser
    {
        public string FullName { get; set; }

        public string BUName { get; set; }

        public string EmployeeType { get; set; }
    }
}
