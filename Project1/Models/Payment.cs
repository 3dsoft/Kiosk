using System;
using System.Collections.Generic;

namespace Project1.Models
{
    public class Payment
    {
        public DateTime dateTime { get; set; }

        public string paymentType { get; set; } // cash, card, etc

        public int totalPrice { get; set; }

        public List<MenuItem> menuItems { get; set; }
    }
}
