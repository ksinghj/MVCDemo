using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Kartar", LastName = "Singh", Age = 20 });
            people.Add(new PersonModel { FirstName = "Tim", LastName = "Ferriss", Age = 40 });
            people.Add(new PersonModel { FirstName = "Lionel", LastName = "Messi", Age = 32 });

            return View(people);
        }
    }
}
