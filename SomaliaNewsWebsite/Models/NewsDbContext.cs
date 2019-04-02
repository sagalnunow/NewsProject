using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SomaliaNewsWebsite.Models
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext() : base("newConnection")
        {

        }

        public DbSet<News> News { get; set; }
    }
}