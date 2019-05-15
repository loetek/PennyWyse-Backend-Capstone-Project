using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PennyWyse.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        
        [DisplayFormat(DataFormatString = "{$}")]
        [Range(0, 100001, ErrorMessage = "Price cannot exceed $100000")]
       
        public double PriceSearch { get; set; }

    }
}
