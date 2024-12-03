using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using NalogENPAnalizer.DataModels;

namespace NalogENPAnalizer
{
    public class MainDbContext : DbContext
    {
        public DbSet<OperationData> Operations { get; set; }
        public DbSet<PokazatelData> Pokazatels { get; set; }
        public DbSet<OktmoData> Oktmo { get; set; }
        public DbSet<KppData> Kpp { get; set; }
        public DbSet<KbkData> Kbk { get; set; }
        public DbSet<DocOsnData> DocOsn { get; set; }

        public MainDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
