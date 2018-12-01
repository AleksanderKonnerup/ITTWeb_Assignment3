using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using Assignment3.ViewModels;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Authorization;

namespace Assignment3.Controllers
{
    [Route("[controller]"), Authorize]
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
                SelectedCategoryId = _context.Category.FirstOrDefaultAsync(x => x.Name == "All").Result.CategoryId
            };

            return View(viewModel);
        }

        [HttpGet("ComponentTypesIndexForCategory")]
        public async Task<IActionResult> ComponentTypesIndexForCategory(int selectedCategoryId)
        {

            var viewModel = new ComponentTypesIndexViewModel()
            {
                ComponentTypes = await _context.ComponentType.ToListAsync(),
            };

            viewModel.Categories = await _context.Category.ToListAsync();
            viewModel.SelectedCategoryId = _context.Category.FirstOrDefaultAsync(x => x.CategoryId == selectedCategoryId).Result.CategoryId;

            return View("ComponentTypesIndex", viewModel);
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

        [HttpGet("Create"), Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var viewModel = new ComponentTypeViewModel()
            {
                Categories = _context.Category.ToList()
            };

            return View(viewModel);
        }


        [HttpPost("Create"), Authorize(Roles = "Admin")]
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
                    Location = componentType.Location,
                    CategorieIdsList = componentType.SelectedCategories
                };


                if (!componentType.Image.FileName.EndsWith(".jpg") && !componentType.Image.FileName.EndsWith(".png"))
                {
                    ViewBag.ImgError = "Please Insert an image of the right file type";
                    return View("Edit", componentType);
                }

                if (componentType.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        await componentType.Image.CopyToAsync(ms);
                        var fileBytes = ms.ToArray();
                        componentTypeModel.Image = fileBytes;
                        componentTypeModel.ImageMimeType = componentType.Image.ContentType;
                        componentTypeModel.FileName = componentType.Image.FileName;
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

            var componentTypeViewModel = new ComponentTypeViewModel()
            {
                ComponentTypeId = componentType.ComponentTypeId,
                AdminComment = componentType.AdminComment,
                ComponentInfo = componentType.ComponentInfo,
                ComponentName = componentType.ComponentName,
                Datasheet = componentType.Datasheet,
                ImageUrl = componentType.ImageUrl,
                Location = componentType.Location,
                Manufacturer = componentType.Manufacturer,
                Status = componentType.Status,
                WikiLink = componentType.WikiLink,
                Image = new FormFile(Stream.Null, 0, 0, componentType.FileName, componentType.FileName)
            };
            
            return View(componentTypeViewModel);
        }

        [HttpPost("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromBody]ComponentTypeViewModel componentType)
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

                if (!componentType.Image.FileName.EndsWith(".jpg"))
                {
                    ViewBag.ImgError = "Please Insert an image of the right file type";
                    return View("Edit", componentType);
                }

                if (componentType.Image != null)
                {

                    using (var reader = new StreamReader(componentType.Image.OpenReadStream()))
                    {
                        string contentAsString = reader.ReadToEnd();
                        byte[] contentAsByteArray = GetBytes(contentAsString);
                        componentTypeModel.Image = contentAsByteArray;
                        componentTypeModel.ImageMimeType = componentType.Image.ContentType;
                        componentTypeModel.FileName = componentType.Image.FileName;
                    }
                }
                
                _context.Update(componentTypeModel);
                await _context.SaveChangesAsync();
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
        public async Task<IActionResult> Delete(long id)
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

        [Route("GetImgFromComponentType")]
        public FileContentResult GetImgFromComponentType(long id)
        {

            byte[] byteArray = _context.ComponentType.Find(id).Image;
            return byteArray != null
                ? new FileContentResult(byteArray, "image/jpg")
                : null;
        }

        private bool ComponentTypeExists(long id)
        {
            return _context.ComponentType.Any(e => e.ComponentTypeId == id);
        }

        private static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
