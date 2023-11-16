using FUC_Syd.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

namespace FUC_Syd.Domain.Data
{
    public class FUC_SydContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public FUC_SydContext() { }
        public FUC_SydContext(DbContextOptions<FUC_SydContext> options) : base(options) { }
        public DbSet<Classes> Classes { get; set; } = null!;
        public DbSet<Grades> Grades { get; set; } = null!;
        public DbSet<Parents> Parents { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<CheckIn> CheckIn { get; set; } = null!;
        public DbSet<SickLeave> SickLeave { get; set; } = null!;
    }

}
