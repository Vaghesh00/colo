using Microsoft.AspNetCore.Mvc;
using ColoWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ColoWebApp.Controllers
{
    public class RackController : Controller
    {
        private static List<Rack> racks = new List<Rack>();

        public IActionResult Index()
        {
            return View(racks);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Rack rack)
        {
            rack.Id = racks.Count + 1;
            racks.Add(rack);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var rack = racks.FirstOrDefault(r => r.Id == id);
            if (rack == null) return NotFound();
            return View(rack);
        }

        [HttpPost]
        public IActionResult Edit(Rack rack)
        {
            var existingRack = racks.FirstOrDefault(r => r.Id == rack.Id);
            if (existingRack == null) return NotFound();

            existingRack.RackName = rack.RackName;
            existingRack.Capacity = rack.Capacity;
            existingRack.UsedSpace = rack.UsedSpace;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var rack = racks.FirstOrDefault(r => r.Id == id);
            if (rack != null) racks.Remove(rack);
            return RedirectToAction("Index");
        }
    }
}