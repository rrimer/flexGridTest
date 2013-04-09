using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using flexGridTest.Models;

namespace flexGridTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData(int page, string sortname, string sortorder, string qtype, string query, int rp)
        {
            return new DataContractJsonSerializedResult(GeneratePersons());
        }

        private PersonsList GeneratePersons()
        {
            var persons = new List<Person>();

            for (int i = 0; i < 10; i++)
            {
                persons.Add(new Person()
                {
                    Id = i,
                    FirstName = "Test" + (10-i).ToString(),
                    SurName = "surname",
                    Email = "asc@mail.ru"
                });
            }

            return new PersonsList(1,1,persons);
        }

    }
}
