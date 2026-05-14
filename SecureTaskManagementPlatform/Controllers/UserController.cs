using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureTaskManagementPlatform.Data;
using SecureTaskManagementPlatform.Models;

namespace SecureTaskManagementPlatform.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult TaskList()
        {
            return View(_context.Tasks.ToList());
        }

        [Authorize(Policy = "CanEditTaskPolicy")]
        public IActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "CanEditTaskPolicy")]
        public IActionResult CreateTask(TaskItem task)
        {
            if(ModelState.IsValid)
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();

                return RedirectToAction("TaskList");
            }

            return View(task);
        }
    }
}