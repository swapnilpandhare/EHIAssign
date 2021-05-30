using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult CreateContact(ContactInfo contactInfo)
        {
            return View("CreateContact", contactInfo);
        }
        public IActionResult Index()
        {
            List<ContactInfo> contactList = new List<ContactInfo>();
            contactList.Add(new ContactInfo { FirstName = "Ram", LastName = "Bhosale", Email = "swap@swap.com", Gender=true });
            return View("Index", contactList);
        }
        [HttpPost]
        public IActionResult UpdateContact(ContactInfo contactInfo)
        {
            List<ContactInfo> contactList = new List<ContactInfo>();
            return View("Index", contactList);
        }
        [HttpPost]
        public IActionResult DeleteContact(ContactInfo contactInfo)
        {
            List<ContactInfo> contactList = new List<ContactInfo>();
            return View("Index", contactList);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
