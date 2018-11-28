using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;
using Microsoft.AspNetCore.Http;

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
    }
}
