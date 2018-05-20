using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext()
        {

        }

        public WorkoutContext(DbContextOptions<WorkoutContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("WorkoutContext");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Workout> Workout { get; set; }
    }
}
