using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Vidéothèque.Models;
// using System.Data.Entity;

namespace Vidéothèque.Context
{
    public class VideothequeContext : DbContext
    {
        private DbSet<Movie> movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn = @"Server=.\SQLEXPRESS;Database=test-db;integrated security=true";
            optionsBuilder.UseSqlServer(cn);
            base.OnConfiguring(optionsBuilder);

        }
    }

    
    
    
}