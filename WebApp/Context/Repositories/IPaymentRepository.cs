using System;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Context.Repositories
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment2> GetAllPayment();

        int GetAllPaymentCount();

        int GetAllPaymentPrice();



        IEnumerable<PaymentList> GetAllPaymentList(DateTime dateTime);

        DateTime GetPaymentbyDateTime(int? id);

        int GetAllPaymentListCount();
    }
}