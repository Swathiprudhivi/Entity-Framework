using System;
using EFITEMS;
using EFITEMS.Models;
using EFITEMS.Context;

namespace EF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add new project
            using (MyContext db = new MyContext())
            {
                Item p = new Item() { item_name = "chicken" ,Price=400};
                Order o = new Order() { OrderDate = Convert.ToDateTime("06.05.2020"), DeliveryDate = Convert.ToDateTime("06.05.2020"),item_id=1 };
                db.Add(p);
                db.SaveChanges();
                db.Add(o);
                db.SaveChanges();
            }
        }
    }
}
