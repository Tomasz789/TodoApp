using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Entities;
using Todo.Domain.Entities.TodoTaskStatus;

namespace TodoApp.DAL.Seeder
{
    public static class DataSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var guids = new Guid[3];

            for (int i = 0; i < guids.Length; i++)
            {
                guids[i] = Guid.NewGuid();
            }

            modelBuilder.Entity<User>().HasData
            (
                new User(guids[0], "Firstuser1", "user1@gmail.com", "aaabb1C#"),
                new User(guids[1], "SecondUser22", "userno2@wp.pl", "bbbAFF##C1"),
                new User(guids[2], "thirdtestUser3", "testUser3@gmail.com", "test#PassworD!")
            ) ;

            modelBuilder.Entity<TodoList>().HasData
            (
                new TodoList("My list", "test list") { Id = 1, UserId = guids[0]},
                new TodoList("My list2", "test list") { Id = 2, UserId = guids[0]},
                new TodoList("My list 3", "test list") { Id = 3, UserId = guids[1] }
            );

            modelBuilder.Entity<TodoTask>().HasData
            (
                new TodoTask("Buy milk", "test", DateTime.Now.AddHours(1), TaskStatus.NotStarted) { Id = 1, TaskListId = 1, Priority=Priority.LOW },
                new TodoTask("Buy coffee", "test", DateTime.Now.AddHours(1), TaskStatus.InProgress) { Id = 2, TaskListId = 2, Priority=Priority.MEDIUM},
                new TodoTask("Do nothing", "test", DateTime.Now.AddHours(1), TaskStatus.Completed) { Id = 3, TaskListId = 1, Priority=Priority.HIGH }
            );
        }
    }
}
