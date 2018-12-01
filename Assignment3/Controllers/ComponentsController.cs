using System.Collections.Generic;
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
            var viewModel = new ComponentIndexViewModel()
            {
                Components = await _context.Component.ToListAsync(),
                ComponentTypes = await _context.ComponentType.ToListAsync(),
                SelectedComponentTypeId = _context.ComponentType.FirstOrDefaultAsync(x => x.ComponentName == "All").Result.ComponentTypeId
            };
           
            return View(viewModel);
        }

        [HttpGet("CreateComponent")]
        public async Task<IActionResult> CreateComponent()
        {
            var viewModel = new ComponentCreateViewModel()
            {
                ComponentTypes = await _context.ComponentType.ToListAsync(),
                SelectedComponentTypeId = _context.ComponentType.FirstOrDefaultAsync(x => x.ComponentName == "All").Result.ComponentTypeId
            };

            return View(viewModel);
        }

        [HttpPost("CreateComponent")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateComponent(ComponentCreateViewModel componentViewModel)
        {
            if (ModelState.IsValid)
            {
                var tempList = new List<long>() { _context.ComponentType.FirstOrDefaultAsync(x => x.ComponentName == "All").Result.ComponentTypeId, componentViewModel.SelectedComponentTypeId};
                componentViewModel.Component.ComponentTypeIdsList = tempList;
                _context.Component.Add(componentViewModel.Component);
                _context.SaveChanges();
                return RedirectToAction("ComponentsIndex");
            }
            return View("ComponentsIndex");
        }

        [HttpGet("Edit")]
        public IActionResult Edit(long? id)
        {
            var component = _context.Component.SingleOrDefault(x => x.ComponentId.Equals(id));
            return View(component);
        }

        [HttpPost("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Component componentModel)
        {
            var _id = componentModel.ComponentId;

            if (ModelState.IsValid) { 
            var component = _context.Component.SingleOrDefault(x => x.ComponentId.Equals(_id));
            _context.Entry<Component>(component).State = EntityState.Detached;
            _context.Entry<Component>(componentModel).State = EntityState.Detached;
            _context.Component.Update(componentModel);

            await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ComponentsIndex));

        }

        [HttpGet("Delete")]
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
        
        [HttpPost("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var component = await _context.Component.FindAsync(id);
            if (component == null)
            {
                return NotFound();
            }
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
