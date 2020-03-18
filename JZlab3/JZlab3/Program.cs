using System;
using System.Linq;

namespace JZlab3
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new Kontekst();
            db.Database.EnsureCreated();
            db.Labs.Add(new Lab() {Nazwa = "P4", GodzinaRozpoczecia = new DateTime(2020, 1, 1, 13, 30, 0) });
            db.SaveChanges();

            var zajecia = db.Labs;

            foreach(var item in zajecia)
            {
                Console.WriteLine($"{item.Id},{item.Nazwa},{item.GodzinaRozpoczecia.ToShortDateString()}");
            }
            var zajeciaDoZmiany = db.Labs.First(x => x.Nazwa.StartsWith("P"));
            zajeciaDoZmiany.Nazwa = "AM2";
            db.Update(zajeciaDoZmiany);
            db.SaveChanges();

            //var nrtcont = new NorthwindContext();
            /*
            foreach (var order in nrtcont.Orders.Include(x=>x.Customer))
            {
                Console.WriteLine(order.Customer.CompanyName);
            }
            */
        }
    }
}
