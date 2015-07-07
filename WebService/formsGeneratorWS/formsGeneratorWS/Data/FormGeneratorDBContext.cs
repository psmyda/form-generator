using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Text;
using formsGeneratorWS.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace formsGeneratorWS.Data
{
    public class FormGeneratorDBContext : DbContext
    {
        public FormGeneratorDBContext() {
            Database.SetInitializer<FormGeneratorDBContext>(null);
        }
        public FormGeneratorDBContext(string connectionString) : base(connectionString) {
            Database.SetInitializer<FormGeneratorDBContext>(null);
        }

        public IDbSet<FormDefinition> FormDefinition { get; set; }
        public IDbSet<FormData> FormData { get; set; }
        public IDbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<FormDefinition>().Property(d => d.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<FormDefinition>().HasKey(d => d.Id);

            builder.Entity<FormData>().Property(d => d.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<FormData>().HasKey(d => d.Id);

            builder.Entity<User>().Property(d => d.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<User>().HasKey(d => d.Id);
        }
    }
}