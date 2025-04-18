using System.Collections.Generic;

namespace ColoWebApp.Models
{
    public class Rack
    {
        public int Id { get; set; }
        public string RackName { get; set; }
        public int Capacity { get; set; } // Total space in the rack
        public int UsedSpace { get; set; } // Space currently in use
        public List<Client> Clients { get; set; } = new List<Client>(); // Clients assigned to this rack
    }
}
