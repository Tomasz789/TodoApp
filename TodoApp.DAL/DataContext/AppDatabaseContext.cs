using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Entities;
using TodoApp.DAL.Seeder;

namespace TodoApp.DAL.DataContext
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoList>().HasMany(t => t.Tasks).WithOne(t => t.TodoList).HasForeignKey(t => t.TaskListId);
            modelBuilder.Entity<User>().HasMany(t => t.TodoLists).WithOne(t => t.User).HasForeignKey(t => t.UserId);
            modelBuilder.Seed();
        }
    }
}
