using Assignment3.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Assignment3.ViewModels
{
    public class ComponentIndexViewModel
    {
        public IEnumerable<Component> Components { get; set; }
        public IEnumerable<ComponentType> ComponentTypes { get; set; }
        public long SelectedComponentTypeId { get; set; }
    }
}
