using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Entities;
using TodoApp.DAL.Wrappers;

namespace ToDoList.WebApp.Controllers
{
    public class ListController : Controller
    {
        private readonly IRepositoryWrapper repository;

        public ListController(IRepositoryWrapper repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var lists = repository.TodoListRepository.GetAll();
            return View(lists);
        }

        // GET:
        public IActionResult Create()
        {
            return View();
        }

        // POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string title, string description)
        {
            var list = new TodoList(title, description);
            this.repository.TodoListRepository.Create(list);
            this.repository.Save();
            return RedirectToAction("Index");
        }
    }
}
