using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDoLab.Model
{
    public class AufgabenContext:DbContext
    {
        public IConfiguration Configuration { get; }
        public AufgabenContext(IConfiguration configuration, DbContextOptions<AufgabenContext> options) : base(options)
        {
            Configuration = configuration;
        }
        public virtual DbSet<Aufgabe> Aufgaben { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ToDoDatabase"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

