using Microsoft.AspNetCore.Mvc;
using PYP_DynamicPartialView.Models;

namespace PYP_DynamicPartialView.Controllers
{
    public class PhoneController : Controller
    {
        List<Phone> phones = new List<Phone>()
        {
            new Phone{ Id=1, Brand="Apple", Model="Iphone-13", Price=3200},
            new Phone{ Id=2, Brand="Samsung", Model="Galaxy-S15", Price=3000},
            new Phone{ Id=3, Brand="Xiomi", Model="Mi-257", Price=1200},
            new Phone{ Id=1, Brand="Huawei", Model="HiS-4", Price=1400},
        };
        Phone phone = new Phone() { Id = 1, Brand = "Apple", Model = "Iphone-14", Price = 3500 };
        public IActionResult Index()
        {
            return View(phones);
        }
    }
}
