using Assignment3.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment3.ViewModels
{
    public class ComponentTypeViewModel
    {
        public long ComponentTypeId { get; set; }
        public string ComponentName { get; set; }
        public string ComponentInfo { get; set; }
        public string Location { get; set; }
        public ComponentTypeStatus Status { get; set; }
        public string Datasheet { get; set; }
        public string ImageUrl { get; set; }
        public string Manufacturer { get; set; }
        public string WikiLink { get; set; }
        public string AdminComment { get; set; }
        public IFormFile Image { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<int> SelectedCategories { get; set; }
    }
}
