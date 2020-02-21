using System;
using EFCoredFirst;
using EFCoredFirst.Models;
namespace EFCoredFirst_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using(PracticeDBContext db=new PracticeDBContext())
            {
                Product p = new Product() { Id = 4, Name = "ac", Price = 1200, Stock = 1, Gst = 12 };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}
