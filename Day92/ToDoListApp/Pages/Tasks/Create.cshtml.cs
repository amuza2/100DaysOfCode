using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoListApp;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly ToDoDbContext _context;
        public ToDoTask Task { get; set; }
        public CreateModel(ToDoDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Task = new ToDoTask
            {
                DueTo = DateTime.Now
            };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var newTask = new ToDoTask();

            if (await TryUpdateModelAsync(newTask, "Task"))
            {
                Task = newTask;
                await _context.AddAsync(Task);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = $"Task successfully created";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
