using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var db = new Context();
            db.Database.EnsureCreated();
            db.Albumys.Add(new Albumy()
            {
                NazwaAlbumu="Kill 'Em All",
                IloscUtworow = 10
            });
            db.SaveChanges();
            var albumy = db.Albumys;
            foreach (var item in albumy)
            {
                Console.WriteLine($@"{item.ID} - {item.NazwaAlbumu} - {item.IloscUtworow}");   
            }*/
            var NorthwindContext = new NorthwindContext();
            var join = NorthwindContext.Orders.Include(x => x.Customer);
            var query = join.Take(5);
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Customer.CustomerId} : {item.OrderId} : {item.OrderDate}");
            }
        }
    }
}