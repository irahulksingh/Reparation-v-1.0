using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HgWorkflow.Models
{
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string  Anummer { get; set; }

        [Required]
        public string  FullName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string confirmPassword { get; set; }


        [Required]
        public string ButikId { get; set; }
    }
}