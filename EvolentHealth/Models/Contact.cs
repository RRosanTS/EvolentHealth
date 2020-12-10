using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvolentHealth.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNbr { get; set; }
        [Required]
        public string Status { get; set; }
        
        public string[] Statuses = new[] { "Active", "InActive" };
    }
}
