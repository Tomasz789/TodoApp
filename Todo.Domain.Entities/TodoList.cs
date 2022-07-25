﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TodoApp.DataVerifier;

namespace Todo.Domain.Entities
{
    public class TodoList
    {
        private readonly IList<TodoTask> todoTasks = new List<TodoTask>();

        public TodoList(string title, string description)
        {
            SetTitle(title);
            SetDescription(description);
            this.CreatedDate = DateTime.Now;
            this.Updated = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="List must have max 100 characters.")]
        [MinLength(1, ErrorMessage = "At least one character required.")]
        public string Title { get; private set; }

        public string Description { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public DateTime Updated { get; private set; }

        public virtual Guid UserId { get; set; }

        public virtual User User { get; set; }


        public virtual IEnumerable<TodoTask> Tasks => todoTasks;

        /// <summary>
        /// Add a new task to to-do list.
        /// </summary>
        /// <param name="todoTask">Task to do.</param>
        /// <returns>Number of items in the task list.</returns>
        /// <exception cref="ArgumentNullException">If the task is null.</exception>
        public int AddTaskToList(TodoTask todoTask)
        {
            if (todoTask == null)
            {
                throw new ArgumentNullException(nameof(todoTask));
            }

            todoTasks.Add(todoTask);

            return todoTasks.Count;
        }

        private bool SetTextValue(string value)
        {
            try
            {
                Verifier.VerifyTextValue(value);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public void SetTitle(string title)
        {
            if (SetTextValue(title))
            {
                this.Title = title;
            }
        }

        public void SetDescription(string description)
        {
            if (SetTextValue(description))
            {
                this.Description = description;
            }
        }
    }
}
