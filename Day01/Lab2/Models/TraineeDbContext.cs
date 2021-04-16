using Microsoft.EntityFrameworkCore;
using Model_Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class TraineeDbContext:DbContext
    {
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Trainee> Trainees { get; set; } 
        public virtual DbSet<Track> Tracks { get; set; }
    }
}
