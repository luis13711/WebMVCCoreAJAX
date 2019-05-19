using WebMVCCoreAJAX.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCCoreAJAX.Models
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options):base(options)
        {
        }

        public DbSet<Workout> Workout { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
