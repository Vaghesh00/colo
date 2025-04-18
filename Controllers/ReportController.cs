using Microsoft.AspNetCore.Mvc;
using ColoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ColoWebApp.Controllers
{
    public class ReportController : Controller
    {
        private static List<Client> clients = new List<Client>(); // Replace with actual data source
        private static List<Rack> racks = new List<Rack>(); // Replace with actual data source
        private static List<Report> reports = new List<Report>();

        public IActionResult Index()
        {
            return View(reports);
        }

        [HttpPost]
        public IActionResult GenerateReports()
        {
            // Generate new reports
            reports = GenerateMonthlyReports();

            // Redirect back to the reports page to show updated data
            return RedirectToAction("Index");
        }

        private List<Report> GenerateMonthlyReports()
        {
            var generatedReports = new List<Report>();

            foreach (var client in clients)
            {
                var rack = racks.FirstOrDefault(r => r.Clients.Any(c => c.Id == client.Id));
                if (rack != null)
                {
                    generatedReports.Add(new Report
                    {
                        ClientId = client.Id,
                        ClientName = client.Name,
                        RackId = rack.Id,
                        RackUsage = 100, // Placeholder for actual usage calculation
                        MonthlyCharge = 150.00m, // Placeholder for actual billing logic
                        ReportDate = DateTime.Now // Use the DateTime type here
                    });
                }
            }

            return generatedReports;
        }
    }
}