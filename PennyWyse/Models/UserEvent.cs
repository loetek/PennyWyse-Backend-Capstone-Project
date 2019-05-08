using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PennyWyse.Models
{
    public class UserEvent : IdentityUser
    {
        public int UserEventId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }



        public virtual ICollection <Event> Events { get; set; }

    }
}
