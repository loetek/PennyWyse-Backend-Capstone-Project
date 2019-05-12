using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PennyWyse.Models
{
    public class UserEvent 
    {

        // This is the model for the user generated list of events.
        [Required]
        [Key]
        public int UserEventId { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int EventId { get; set; }
        public Event Event { get; set; }

        public virtual ICollection <Event> Events { get; set; }

    }
}
