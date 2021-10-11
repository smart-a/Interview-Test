using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestDomeMVC.Controllers;
using TestDomeMVC.Models;

namespace TestDomeMVC.Controllers
{

    public class Item
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Count { get; set; }
    }
    
    public class Person
    {
        public string Name { get; set; }
        public Contact Contact { get; set; }
    }
    public class Contact
    {
        public string PhoneNumber { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Create()
        {
            return View();
        }
        public static List<Person> Persons = new List<Person>();
        public IActionResult New(Person person)
        {
            Persons.Add(new Person()
            {
                Name = person.Name,
                Contact = person.Contact
            });
            // return View("Index");
            return RedirectToRoute();
        }

        public IActionResult List()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}