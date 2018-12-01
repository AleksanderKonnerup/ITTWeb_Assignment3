using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace Assignment3.Models
{
    public class ComponentType
    {
        public ComponentType()
        {
            //ComponentIdsList = new List<int>();
            CategorieIdsList = new List<int>();
        }
        [Key]
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
        public string FileName { get; set; }
        public string ImageMimeType { get; set; }
        public byte[] Image { get; set; }
        //[NotMapped]
        //public IEnumerable<int> ComponentIdsList { get; set; }
        [NotMapped]
        public IEnumerable<int> CategorieIdsList { get; set; }
        //public string ComponentIds
        //{
        //    get { return string.Join(',', ComponentIdsList); }
        //    set { ComponentIdsList = value.Split(',').Cast<int>().AsEnumerable(); }
        //}
        public string CategorieIds
        {
            get { return string.Join(',', CategorieIdsList); }
            set
            {
                var tempValue = value.Split(',');
                var fin = new List<int>();

                foreach (var val in tempValue)
                {
                    fin.Add(Int32.Parse(val));
                }

                CategorieIdsList = fin;
            }
        }
    }
}
