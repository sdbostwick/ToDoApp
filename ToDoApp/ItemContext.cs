using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace ToDoApp
{
    public class ItemContext : DbContext
    {
        public DbSet<ToDoItem> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            string DatabaseFile = Path.Combine(ProjectBase.FullName, "Items.db");
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}
