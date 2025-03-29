using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoListApp;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        private readonly ToDoDbContext _context;
        public DeleteModel(ToDoDbContext context)
        {
            _context = context;
        }
        public IActionResult OnPostDeleteTask(Guid id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            _context.Tasks.Remove(task);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Task deleted successfully!";

            return RedirectToPage();
        }
    }
}
