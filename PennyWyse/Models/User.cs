using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PennyWyse.Models
{
    public class User : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Photo URL")]
        public string ProfileImageURL { get; set; }

        public virtual ICollection<Event> Events { get; set; }


        [Display(Name = "User's Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
