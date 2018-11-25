using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using Assignment3.ViewModels;

namespace Assignment3.Controllers
{
    public class ComponentTypesController : Controller
    {
        private readonly Assignment3Context _context;

        public ComponentTypesController(Assignment3Context context)
        {
            _context = context;
        }

        // GET: ComponentTypes
        public async Task<IActionResult> ComponentTypesIndex()
        {
            var viewModel = new ComponentTypesIndexViewModel() {
                ComponentTypes = await _context.ComponentType.ToListAsync(),
                //Categories = await _context.Category.ToListAsync(),
                //SelectedCategoryId = _context.Category.SingleOrDefaultAsync(x => x.Name == "All").Result.CategoryId
            };

            return View(viewModel);
        }

        // GET: ComponentTypes/Details/5
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

        // GET: ComponentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComponentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ComponentTypeId,ComponentName,ComponentInfo,Location,Status,Datasheet,ImageUrl,Manufacturer,WikiLink,AdminComment")] ComponentType componentType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(componentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ComponentTypesIndex));
            }
            return View(componentType);
        }

        // GET: ComponentTypes/Edit/5
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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ComponentTypeId,ComponentName,ComponentInfo,Location,Status,Datasheet,ImageUrl,Manufacturer,WikiLink,AdminComment")] ComponentType componentType)
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

        // GET: ComponentTypes/Delete/5
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

        // POST: ComponentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var componentType = await _context.ComponentType.FindAsync(id);
            _context.ComponentType.Remove(componentType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ComponentTypesIndex));
        }

        private bool ComponentTypeExists(long id)
        {
            return _context.ComponentType.Any(e => e.ComponentTypeId == id);
        }
    }
}
