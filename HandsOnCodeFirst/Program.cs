using System;
using HandsOnCodeFirst.Context;
using HandsOnCodeFirst.Models;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MyContext db=new MyContext())
            {
                //define new record
                //Student s = new Student() { Sname = "swathi", Age = 10, Std = "IT" };
                //db.Students.Add(s);
                //db.SaveChanges();
                //fetch record
                //Student s = db.Students.Find(1);
                //Console.WriteLine("welcome {0}", s.Sname);
                //fetch one record using non primary key
                Student s1 = db.Students.SingleOrDefault(i => i.Sname == "swathi");
                List<Student> list = db.Students.Where(i => i.Age == 10).ToList();
                List<Student> list1 = db.Students.Where(i => i.Age == 10 && i.Std=="IT").ToList();

                //update record
                Student s2 = db.Students.Find(1);
                s2.Age = 11;
                db.Students.Update(s2);
                db.SaveChanges();

                //delete record
                Student s3 = db.Students.SingleOrDefault(i => i.Sname == "swathi");
                db.Students.Remove(s3);
                db.SaveChanges();
            }
        }
    }
}
