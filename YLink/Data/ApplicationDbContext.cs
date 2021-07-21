using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YLink.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Link>()
                .HasAlternateKey(l => l.Key);

            builder.Entity<Link>()
                .HasIndex(l => l.Key);
        }
    }

    public class Link
    {
        public int Id { get; set; }


        [Required]
        public string Key { get; set; }

        [Url]
        [Required]
        public string Url { get; set; }

        
        [Required]
        public string Description { get; set; }

    }
}
