using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tasnadi_Botond_Lab8.Models;

namespace Tasnadi_Botond_Lab8.Data
{
    public class Tasnadi_Botond_Lab8Context : DbContext
    {
        public Tasnadi_Botond_Lab8Context (DbContextOptions<Tasnadi_Botond_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tasnadi_Botond_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tasnadi_Botond_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Tasnadi_Botond_Lab8.Models.Category> Category { get; set; }

        public DbSet<Tasnadi_Botond_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
