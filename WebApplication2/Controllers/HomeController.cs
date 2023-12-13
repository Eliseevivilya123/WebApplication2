using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 

using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
      
        private List<Contact> contacts = new List<Contact>
    {
        new Contact { Id = 1, LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", PhoneNumber = "1234567890", Address = "Москва", Description = "Пример записи 1" },
        new Contact { Id = 2, LastName = "Петров", FirstName = "Петр", MiddleName = "Петрович", PhoneNumber = "0987654321", Address = "Санкт-Петербург", Description = "Пример записи 2" }
    };
        private ActionResult NotFound()
        {
            return new ViewResult()
            {
                ViewName = "NotFound"
            };
        }

    }
}