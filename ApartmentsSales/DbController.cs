using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmentsSales.Entities;

namespace ApartmentsSales
{
    class DbController : IDisposable
    {
        private LocalContext Context { get; set; } = new LocalContext();
        private bool isDisposed = false;
        public DbController()
        {
        }
        ~DbController()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
            {
                return;
            }

            if (disposing)
            {
                Context.Dispose();
            }

            isDisposed = true;
        }

        public List<SaleRequest> GetSaleRequests(string type)
        {
            Context.SaleRequests.Load();

            return Context.SaleRequests.Local.Where(r => r.Type == type).ToList();
        }

        public SaleRequest SetSaleRequest(SaleRequest request)
        {
            var newRequest = Context.SaleRequests.Add(request);
            Context.SaveChanges();
            return newRequest;
        }

        /*public List<CarParking> GetCars(DateTime? from, DateTime? to)
        {
            Context.CarParking.Load();

            return Context.CarParking.Local.Where(c => c.DateStartParking >= from && c.DateStartParking <= to).ToList();
        }


        public CarParking SetCar(CarParking car)
        {
            var newCar = Context.CarParking.Add(car);
            Context.SaveChanges();
            return newCar;
        }*/

        /*public List<User> GetUsers(bool isAny = true, bool isDeleted = false)
        {
            Context.Users.Load();
            Context.Skills.Load();
            Context.Leads.Load();

            return Context.Users.Local
                .Where(x => (x.IsDeleted == isDeleted) || isAny)
                .ToList();
        }*/
    }
}
