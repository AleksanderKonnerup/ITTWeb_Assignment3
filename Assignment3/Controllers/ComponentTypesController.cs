using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using Assignment3.ViewModels;
namespace Assignment3.Controllers
{
    [Route("[controller]")]
    public class ComponentTypesController : Controller
    {
        private readonly Assignment3Context _context;

        public ComponentTypesController(Assignment3Context context)
        {
            _context = context;
        }

        [HttpGet("ComponentTypesIndex")]
        public async Task<IActionResult> ComponentTypesIndex()
        {
            var viewModel = new ComponentTypesIndexViewModel() {
                ComponentTypes = await _context.ComponentType.ToListAsync(),
                Categories = await _context.Category.ToListAsync(),
                SelectedCategoryId = _context.Category.SingleOrDefaultAsync(x => x.Name == "All").Result.CategoryId
            };

            return View(viewModel);
        }

        [HttpGet("Details")]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentType = await _context.ComponentType
                .FirstOrDefaultAsync(m => m.ComponentTypeId == id);
            if (componentType == null)
            {
                return NotFound();
            }

            return View(componentType);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ComponentTypeViewModel componentType)
        {
            if (ModelState.IsValid)
            {
                    var componentTypeModel = new ComponentType()
                    {
                        ComponentName = componentType.ComponentName,
                        ComponentInfo = componentType.ComponentInfo,
                        Status = componentType.Status,
                        Datasheet = componentType.Datasheet,
                        WikiLink = componentType.WikiLink,
                        Manufacturer = componentType.Manufacturer,
                        AdminComment = componentType.AdminComment,
                        ImageUrl = componentType.ImageUrl,
                    };
                using (var memoryStream = new MemoryStream())
                {
                    if (!componentType.Image.FileName.EndsWith(".jpg"))
                    {
                        ViewBag.ImgError = "Please Insert an image of the right file type";
                        return View("Create", componentType);
                    }

                    await componentType.Image.CopyToAsync(memoryStream);
                    if (componentTypeModel.Image != null)
                    {
                        componentTypeModel.Image.ImageData = memoryStream.ToArray();
                    }
                }
                _context.Add(componentTypeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ComponentTypesIndex));
                
            }
            return View(componentType);
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentType = await _context.ComponentType.FindAsync(id);
            if (componentType == null)
            {
                return NotFound();
            }
            return View(componentType);
        }

        // POST: ComponentTypes/Edit/5
        [HttpPost("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, ComponentType componentType)
        {
            if (id != componentType.ComponentTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(componentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComponentTypeExists(componentType.ComponentTypeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ComponentTypesIndex));
            }
            return View(componentType);
        }

        [HttpGet("Delete")]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentType = await _context.ComponentType
                .FirstOrDefaultAsync(m => m.ComponentTypeId == id);
            if (componentType == null)
            {
                return NotFound();
            }

            return View(componentType);
        }

        [HttpPost("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var componentType = await _context.ComponentType.FindAsync(id);

            if(componentType == null)
            {
                return NotFound();
            }
;            _context.ComponentType.Remove(componentType);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(ComponentTypesIndex));
        }

        private bool ComponentTypeExists(long id)
        {
            return _context.ComponentType.Any(e => e.ComponentTypeId == id);
        }

    }
}
