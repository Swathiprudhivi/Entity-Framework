using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFDALItem.Models;

namespace EFDALItem.MyContext
{
  public class MyContext1:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MESBIGN\SQLEXPRESS;Initial Catalog=EMITEMDB;User ID=sa;Password=pass@word1");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
