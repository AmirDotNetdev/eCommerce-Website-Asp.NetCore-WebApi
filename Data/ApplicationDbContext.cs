using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using tamrin2.Models;

namespace tamrin2.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customers>
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
            
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
    }
}