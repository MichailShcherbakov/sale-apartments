using ApartmentsSales.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentsSales
{
    public class LocalContext : DbContext
    {
        public LocalContext() : base("LocalDb")
        {
            Database.SetInitializer(new InitializerDB());
        }

        public DbSet<SaleRequest> SaleRequests { get; set; }
    }
}
