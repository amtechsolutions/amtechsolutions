using Amtech.BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Dynamic;
namespace Amtech.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //ViewBag.title = "Hi!! From";
            //dynamic data = new ExpandoObject();
            //data.id = 10;
            //data.name = "Ganesh";
            //ViewBag.Data = data;
            //ViewBag.bk = new Book { author = "R.K.Sampsaon", Id = 786 };
            return View();
        }
        public ViewResult AboutUs()
        {
            // return View("../../UI/MyUI");
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
