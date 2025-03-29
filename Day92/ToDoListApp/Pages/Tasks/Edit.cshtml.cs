using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ToDoListApp;

namespace MyApp.Namespace
{
    public class EditModel : PageModel
    {
        private readonly ToDoDbContext _context;
        public ToDoTask Task { get; set; }

        public EditModel(ToDoDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(Guid id)
        {
            Task = _context.Tasks.FirstOrDefault(t => t.Id == id);

            if (Task is null)
                return RedirectToPage("Create");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);

            if (task is null)
                return RedirectToPage("Index");

            // if (!ModelState.IsValid)
            //     return Page();

            if (await TryUpdateModelAsync(task, "Task"))
            {
                _context.Update(task);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = $"Task successfully updated";
            }

            return RedirectToPage("Index");
        }
    }
}


