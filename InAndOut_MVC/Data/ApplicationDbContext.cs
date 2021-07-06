using System;
using Microsoft.EntityFrameworkCore;
using InAndOut_MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> Categories { get; set; }
    }
}
