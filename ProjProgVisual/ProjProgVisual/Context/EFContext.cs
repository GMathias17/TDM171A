using ProjProgVisual.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjProgVisual.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public EFContext()
            : base("Asp_Net_MVC_CS")
        {
            
        }
    }
}