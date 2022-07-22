using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RailwaySystem.API.Model;

namespace RailwaySystem.API.Data
{
    public class TrainDbContext : DbContext
    {
        public TrainDbContext(DbContextOptions<TrainDbContext> options) : base(options)
        {

        }
        public DbSet<User> user { get; set; }
        //public DbSet<Train> train { get; set; }
        //public DbSet<Booking> booking { get; set; }
        public DbSet<Transaction> transaction { get; set; }
        public DbSet<Seat> seat { get; set; }
        //public DbSet<Ticket> ticket { get; set; }
        public DbSet<BankCred> bankcred { get; set; }
        //public DbSet<Station> station { get; set; }
    }
}
