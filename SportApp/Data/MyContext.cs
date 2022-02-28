using Microsoft.EntityFrameworkCore;
using SportApp.Models.Entities;

namespace SportApp.Models
{
    public class MyContext:DbContext
    {
       

        
        public DbSet<UserRespondes> UserRespondes { get; set; }
        public DbSet<PersonalAccount> PersonalAccounts { get; set; }
        public DbSet<TypeOfFood> FoodType { get; set; }  
        public DbSet<TypeOfActivity> ActivityType { get; set; } 
        public DbSet<Diseases> Diseases { get; set; }
        public DbSet<DietPlan> DietPlan { get; set; }   
        public DbSet<UserLogIn> UserLogIn { get; set; } 
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<UserRespondes>().ToTable("UserRespondes");
             
        }
    }
        
}

