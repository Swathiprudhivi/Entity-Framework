﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoredFirst.Models
{
    public partial class PracticeDBContext : DbContext
    {
        public PracticeDBContext()
        {
        }

        public PracticeDBContext(DbContextOptions<PracticeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MESBIGN\\SQLEXPRESS;Initial Catalog=PracticeDB;User ID=sa;Password=pass@word1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__employee__D9509F6D1256653B");

                entity.ToTable("employee");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasColumnType("date");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK__employee__pid__15502E78");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Gst).HasColumnName("gst");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__project__DD37D91A51FBC38A");

                entity.ToTable("project");

                entity.HasIndex(e => e.Pname)
                    .HasName("UQ__project__1FC9734CDADF4E7C")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("date");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
