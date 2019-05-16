using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PennyWyse.Models.ViewModels
{
    public class UserEventViewModel
    {
        public UserEvent UserEvent { get; set; }
        public List<UserEvent> UserEventList = new List<UserEvent>();

        public Event Event { get; set; }
        public List<Event> EventList = new List<Event>();

        public bool EventFlag { get; set; }

        public void FlagChecker()
        {

        }

    }
}
