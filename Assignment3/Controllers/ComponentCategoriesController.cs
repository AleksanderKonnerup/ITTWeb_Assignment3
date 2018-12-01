using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using Assignment3.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Assignment3.Controllers
{
    [Route("[controller]"), Authorize]
    public class ComponentCategoriesController : Controller
    {
        private readonly Assignment3Context _context;

        public ComponentCategoriesController(Assignment3Context context)
        {
            _context = context;
        }

        [HttpGet("ComponentCategoriesIndex")]
        public async Task<IActionResult> ComponentCategoriesIndex()
        {
            return View(await _context.Category.ToListAsync());
        }

        [HttpGet("Details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpGet("Create"), Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost("Create"), Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ComponentCategoriesIndex));
            }
            return View(category);
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int CategoryId, string Name)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var temp = await _context.Category.FirstOrDefaultAsync(x => x.CategoryId == CategoryId);
                    temp.Name = Name;
                    _context.Update(temp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ComponentCategoriesIndex));
            }
            return View();
        }

        [HttpGet("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int CategoryId)
        {
            var category = await _context.Category.FindAsync(CategoryId);
            if (category == null)
            {
                return NotFound();
            }
            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ComponentCategoriesIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }

        [HttpGet("List")]
        public async Task<IActionResult> List(Category category)
        {
            var Category = await _context.Category.FindAsync(category.CategoryId);
            var componentTypes = Category.ComponentTypes.ToList();
            var viewModel = new ComponentTypeListViewModel()
            {
                ComponentTypesList = componentTypes
            };

            return View(viewModel);
        }
    }
}
