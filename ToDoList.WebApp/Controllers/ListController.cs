using Microsoft.AspNetCore.Mvc;
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
    }
}
