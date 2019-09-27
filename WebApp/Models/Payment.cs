using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Payment
    {
        public DateTime dateTime { get; set; }

        public string paymentType { get; set; } // cash, card, etc

        public int totalPrice { get; set; }

        public List<MenuItem> menuItems { get; set; }
    }
}
