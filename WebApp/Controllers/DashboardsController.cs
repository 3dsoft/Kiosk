using Microsoft.AspNetCore.Mvc;
using WebApp.Context.Repositories;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class DashboardsController : Controller
    {
        private readonly IPaymentRepository _paymentRepository;

        public DashboardsController(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }


        public IActionResult Index()
        {
            return RedirectToAction("Dashboard2");
        }

        public IActionResult Dashboard1()
        {
            return View();
        }

        public IActionResult Dashboard2()
        {
            //ViewBag.TotalUser = _paymentRepository.GetAllPaymentCount();

            //ViewBag.TotalPayment = _paymentRepository.GetAllPaymentListCount();

            //ViewBag.TotalPrice = _paymentRepository.GetAllPaymentPrice().ToString("C");

            PaymentViewModel payment = new PaymentViewModel()
            {
                TotalUser = _paymentRepository.GetAllPaymentCount(),
                TotalPayment = _paymentRepository.GetAllPaymentListCount(),
                TotalPrice = _paymentRepository.GetAllPaymentPrice()
            };

            return View(payment);
        }

    }
}