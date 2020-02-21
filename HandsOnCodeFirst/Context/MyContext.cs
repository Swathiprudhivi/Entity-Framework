using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsOnCodeFirst.Models;
namespace HandsOnCodeFirst.Context
{
    class MyContext:DbContext
    {
        //Define entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MESBIGN\SQLEXPRESS;Initial Catalog=StudentDB;User ID=sa;Password=pass@word1");

           
        }
    }
}
