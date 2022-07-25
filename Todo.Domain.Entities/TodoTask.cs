using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Todo.Domain.Entities.TodoTaskStatus;
using TodoApp.DataVerifier;

namespace Todo.Domain.Entities
{
    public class TodoTask
    {
        public TodoTask(string title, string description, DateTime endDate, TaskStatus status)
        {
            SetTaskTitle(title);
            CheckEndDate(endDate);
            this.Description = description;
            this.CreatedDate = DateTime.Now;
            this.Updated = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "List title must have max 100 characters.")]
        [MinLength(1, ErrorMessage = "At least one character required.")]
        public string Title { get; private set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public DateTime Updated { get; set; }

        public TaskStatus Status { get; set; }

        public Priority Priority { get; set; }

        public virtual int TaskListId { get; set; }

        public virtual TodoList TodoList { get; set; }

        public bool CheckEndDate(DateTime dateTime)
        {
            try
            {
                Verifier.VerifyDate(dateTime);
            }
            catch (ArgumentException)
            {
                return false;
            }

            this.EndDate = dateTime;
            return true;
        }

        public void SetTaskTitle(string title)
        {
            try
            {
                Verifier.VerifyTextValue(title);
            }
            catch (ArgumentException)
            {
                return;
            }

            this.Title = title;
        }
    }
}
