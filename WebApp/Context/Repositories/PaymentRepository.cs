using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Context.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly WebAppContext _context;

        public PaymentRepository(WebAppContext context)
        {
            _context = context;
        }


        // ## Payment ######################################################################

        /// <summary>
        /// 결제 결과만 가져온다. (상세 항목 제외)
        /// </summary>
        public IEnumerable<Payment2> GetAllPayment()
        {
            return _context.Payments.OrderBy(c => c.dateTime).ToList();
        }

        /// <summary>
        /// 총 결제 개수
        /// </summary>
        public int GetAllPaymentCount()
        {
            return _context.Payments.OrderBy(c => c.dateTime).Count();
        }

        public DateTime GetPaymentbyDateTime(int? id)
        {
            var res = _context.Payments.Where(c => c.Id == id).FirstOrDefault();
            return res.dateTime;
        }

        public int GetAllPaymentPrice()
        {
            int hap = 0;

            hap += _context.Payments.Sum(c => c.totalPrice);

            return hap;
        }

        // ## PaymentList ######################################################################

        /// <summary>
        /// 결제 상세 내역만 가져온다.
        /// dateTime값을 기준으로 같은것을 가져온다.
        /// </summary>
        public IEnumerable<PaymentList> GetAllPaymentList(DateTime dateTime)
        {
            return _context.PaymentLists.Where(c => c.dateTime == dateTime).ToList();
        }

        /// <summary>
        /// 전체 결제 상세 내역 개수
        /// </summary>
        public int GetAllPaymentListCount()
        {
            return _context.PaymentLists.Count();
        }



        // ## Save ######################################################################

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
