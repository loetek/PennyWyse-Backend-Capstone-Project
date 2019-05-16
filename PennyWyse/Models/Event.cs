using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PennyWyse.Models
{
    public class Event
    {
        [Required]
        public int EventId { get; set; }

        [Required]
        [Display(Name = "Event Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Event Price")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Event Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Event Description")]
        public string Description { get; set; }
        [Display(Name = "More Info URL")]
        public string InfoURL { get; set; }
        [Display(Name = "Event Image URL")]
        public string ImageURL { get; set; }
        [Display(Name = "Event City")]
        public string City { get; set; }
        [Display(Name = "Event State")]
        public string State { get; set; }
        [Display(Name = "Event Type")]
        public string EventType { get; set; }
        [Display(Name = "Creator")]
        public string CreatorId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }



        [Display(Name = "Event Location")]
        public string LocationFull
        {
            get
            {
                return $"{City} , {State}";
            }
        }



    }
}
