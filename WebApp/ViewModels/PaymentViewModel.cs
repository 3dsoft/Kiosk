using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class PaymentViewModel
    {
        public IEnumerable<Payment2> Payment { get; set; }

        public int TotalUser { get; set; }

        public int TotalPayment { get; set; }

        public int TotalPrice { get; set; }
    }
}
