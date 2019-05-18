using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PiePizzeria.Models;

namespace PiePizzeria.Controllers
{
    public class HomeController : Controller
    {
        private readonly iPieRepository _pieRepository;

        public HomeController(iPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public ViewResult Index()
        {
            ViewBag.Message = "Welcome to the Pie Pizzeria!";
            return View();
        }
    }
}