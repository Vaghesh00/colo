using Microsoft.AspNetCore.Mvc;
using ColoWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ColoWebApp.Controllers
{
    public class ClientController : Controller
    {
        private static List<Client> clients = new List<Client>();

        public IActionResult Index()
        {
            return View(clients);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Client client)
        {
            client.Id = clients.Count + 1;
            clients.Add(client);
            return RedirectToAction("Index");
        }
    }
}
