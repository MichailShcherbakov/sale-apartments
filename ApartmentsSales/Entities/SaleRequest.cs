using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentsSales.Entities
{
    public class SaleRequest
    {
        public int Id { get; set; } = 0;

        public string AgentName { get; set; } = "";
        public string ClientName { get; set; } = "";
        public int ApartmentRoomCount { get; set; } = 0;
        public int ApartmentFloor { get; set; } = 0;
        public float ApartmentArea { get; set; } = 0;
        public string Type { get; set; } = "";
    }
}
