using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VLADULESCU_GABRIEL_Lab2.Models;

namespace VLADULESCU_GABRIEL_Lab2.Data
{
    public class VLADULESCU_GABRIEL_Lab2Context : DbContext
    {
        public VLADULESCU_GABRIEL_Lab2Context (DbContextOptions<VLADULESCU_GABRIEL_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<VLADULESCU_GABRIEL_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<VLADULESCU_GABRIEL_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<VLADULESCU_GABRIEL_Lab2.Models.Category> Category { get; set; }
    }
}
