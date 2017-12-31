using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFrameworkCodeFirst.Migrations;

namespace EntityFrameworkCodeFirst
{

    public class CarLot
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }

    public class CarLotDbContext : DbContext
    {
        public DbSet<CarLot> CarLot { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var context = new CarLotDbContext();
            var car1 = new CarLot()
            { Year = 2010,Make = "Honda", Model = "CVR", Price = 10000};

            var car2 = new CarLot()
            { Year = 2012, Make = "Honda", Model = "Accord", Price = 90000};

            var car3 = new CarLot()
            { Year = 2013, Make = "Honda", Model = "Civic", Price = 80000};
            context.CarLot.Add(car1);
            context.CarLot.Add(car2);
            context.CarLot.Add(car3);
            context.SaveChanges();

        }
    }
}
