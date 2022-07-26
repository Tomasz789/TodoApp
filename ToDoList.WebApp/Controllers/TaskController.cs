using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoApp.DAL.Wrappers;

namespace ToDoList.WebApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly IRepositoryWrapper wrapper;

        public TaskController(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }
        public IActionResult Index(int listId)
        {
            var model = this.wrapper.TodoTaskRepository.GetAll().Where(x => x.TaskListId == listId);
            return View(model);
        }
    }
}
