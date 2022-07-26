using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Entities;
using Todo.Domain.Entities.TodoTaskStatus;
using TodoApp.DAL.DataContext;
using TodoApp.DAL.Wrappers;

namespace TodoApp.DAL.Seeder
{
    public class RunAppSeeder
    {
        private readonly IRepositoryWrapper repositoryWrapper;
        private readonly AppDatabaseContext ctx;
        public RunAppSeeder(AppDatabaseContext appDatabaseContext)
        {
            this.ctx = appDatabaseContext;
        }

        public void Seed()
        {
            Guid id = Guid.NewGuid();
            var seededUser = new User(id, "appUser22", "appUser22@example.com", "R3!dOO548#");
            this.ctx.Users.Add(seededUser);
            this.ctx.SaveChanges();

            var list1 = new TodoList("Lorem ipsum dolor 1", "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse");
            var list2 = new TodoList("Lorem ipsum dolor 2", "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse");
            var list3 = new TodoList("Lorem ipsum dolor 3", "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse");
            var list4 = new TodoList("Lorem ipsum dolor 4", "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse");
            var list5 = new TodoList("Lorem ipsum dolor 5", "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse");

            list1.UserId = id;
            list2.UserId = id;
            list3.UserId = id;
            list4.UserId = id;
            list5.UserId = id;

            for (int i = 0; i < 5; i++)
            {
                list1.AddTaskToList(new TodoTask("Lorem ipsum", "Lorem ipsum dolor 4", DateTime.Now.AddYears(1), TaskStatus.NotStarted));
            }

            for (int i = 0; i < 3; i++)
            {
                list2.AddTaskToList(new TodoTask("Lorem ipsum 2", "Lorem ipsum dolor 4", DateTime.Now.AddYears(1), TaskStatus.InProgress));
                list3.AddTaskToList(new TodoTask("Lorem ipsum 3", "Lorem ipsum dolor 3edkofijo", DateTime.Now.AddYears(1), TaskStatus.Completed));

            }

            for (int i = 0; i < 3; i++)
            {
                list4.AddTaskToList(new TodoTask("Lorem ipsum 223erfg", "Lorem ipsum dolor 4", DateTime.Now.AddYears(1), TaskStatus.InProgress));
                list5.AddTaskToList(new TodoTask("Lorem ipsum defrgtb3", "Lorem ipsum dolor Lorem ipsum dolor 3edkofijo", DateTime.Now.AddYears(1), TaskStatus.NotStarted));
            }

            var taskList = new List<TodoList>();

            taskList.Add(list1);
            taskList.Add(list2);
            taskList.Add(list3);
            taskList.Add(list4);
            taskList.Add(list5);

            this.ctx.AddRange(taskList);
            this.ctx.SaveChanges();
        }
    }
}
