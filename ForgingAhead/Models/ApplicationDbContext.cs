using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ForgingAhead.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }


        public DbSet<Character> Characters { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

    }
}