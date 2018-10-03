using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCapp.Models;

namespace MVCapp.Controllers
{
    public class CostumersController : Controller
    {
        // GET: Costumers
        public ActionResult Index()
        {
            var costumers = getCostumers();
            return View(costumers);
        }

        public ActionResult Details(int id)
        {
            var costumers = getCostumers();
            foreach(var costumer in costumers)
            {
                if (costumer.Id == id) return View(costumer);
            }
            return HttpNotFound();
        }

        private List<Costumer> getCostumers()
        {
            return new List<Costumer>
            {
                new Costumer{Id = 1, Name = "Ivan"},
                new Costumer{Id = 2, Name = "Vladimir"}
            };
        }
    }

    
}