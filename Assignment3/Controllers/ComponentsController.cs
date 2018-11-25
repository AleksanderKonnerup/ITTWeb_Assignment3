using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly Assignment3Context _context;

        public ComponentsController(Assignment3Context context)
        {
            _context = context;
        }

        [HttpGet("ComponentIndex")]
        public async Task<IActionResult> ComponentsIndex()
        {
            var components = await _context.Component.ToListAsync();
            return View(components);
        }

        [HttpGet("CreateComponent")]
        public IActionResult CreateComponent()
        {
            return View();
        }

        [HttpPost("CreateComponent")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Component componentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Component.Add(componentModel);
                _context.SaveChanges();
                return RedirectToAction("ComponentsIndex");
            }
            return View("ComponentsIndex");
        }

        // GET: Components/Edit/5
        [HttpGet("EditComponent")]
        public IActionResult Edit(long? id)
        {
            var component = _context.Component.SingleOrDefault(x => x.ComponentId.Equals(id));
            return View(component);
        }

        [HttpPost("EditComponent")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Component componentModel)
        {
            var _id = componentModel.ComponentId;

            var component = _context.Component.SingleOrDefault(x => x.ComponentId.Equals(_id));
            _context.Entry<Component>(component).State = EntityState.Detached;
            _context.Entry<Component>(componentModel).State = EntityState.Detached;
            if (component != null)
            {
                _context.Component.Update(componentModel);
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Component.Add(componentModel);
                }
            }


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ComponentsIndex));
        }

        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var component = await _context.Component
                .FirstOrDefaultAsync(m => m.ComponentId == id);
            if (component == null)
            {
                return NotFound();
            }

            return View(component);
        }

        // POST: Components/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var component = await _context.Component.FindAsync(id);
            _context.Component.Remove(component);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ComponentsIndex));
        }

        private bool ComponentExists(long id)
        {
            return _context.Component.Any(e => e.ComponentId == id);
        }
    }
}
