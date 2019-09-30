using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Context.Repositories;
using WebApp.Models;

namespace Company.WebApplication1.Pages.Tables
{
    public class DataTableModel : PageModel
    {
        private readonly IPaymentRepository _paymentRepository;

        public DataTableModel(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }


        [BindProperty]
        public IEnumerable<Payment2> Payment { get; set; }

        [BindProperty]
        public IEnumerable<PaymentList> PaymentList { get; set; }


        public void OnGet(int? id)
        {
            Payment = _paymentRepository.GetAllPayment();

            if(id != null)
            {
                var dt = _paymentRepository.GetPaymentbyDateTime(id);
                PaymentList = _paymentRepository.GetAllPaymentList(dt);
            }
        }
    }
}