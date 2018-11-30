using System.Collections.Generic;
using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.ViewModels
{
    public class ComponentTypesIndexViewModel
    {
        public int SelectedCategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<ComponentType> ComponentTypes { get; set; }
    }
}
