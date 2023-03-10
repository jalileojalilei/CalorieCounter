using CalorieCounterDataAccess.Configuration;
using CalorieCounterEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounterDataAccess
{
    public class CalorieCounterContext : DbContext
    {
        // Database Tables
        public DbSet<FoodCategoryEntity> FoodCategoryEntityTable { get; set; }

        public DbSet<FoodEntity> FoodEntityTable { get; set; }

        public DbSet<MealCategoryEntity> MealCategoryEntityTable { get; set; }

        public DbSet<MealEntity> MealEntityTable { get; set; }

        public DbSet<PhotographEntity> PhotographEntityTable { get; set; }

        public DbSet<UserEntity> UserEntityTable { get; set; }

        // OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8BU397I;Initial Catalog=CalorieCounterDB;user Id=sa;Password=asdqwe123");
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FJAHODS;Initial Catalog=CalorieCounterDB;user Id=sa;Password=Kurumsal123");
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q56AEMU\MSSQLKD14;Initial Catalog=CalorieCounterDB;user Id=sa;Password=Beste1998.");

            base.OnConfiguring(optionsBuilder);
        }

        // OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodCategoryConfiguration())
                        .ApplyConfiguration(new FoodConfiguration())
                        .ApplyConfiguration(new MealCategoryConfiguration())
                        .ApplyConfiguration(new MealConfiguration())
                        .ApplyConfiguration(new PhotographConfiguration())
                        .ApplyConfiguration(new UserConfiguration());
        }
    }
}
