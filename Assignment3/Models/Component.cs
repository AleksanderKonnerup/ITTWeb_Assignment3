using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class Component
    {
        public long ComponentId { get; set; }
        public long ComponentTypeId { get; set; }
        public int ComponentNumber { get; set; }
        public string SerialNo { get; set; }
        public ComponentStatus Status { get; set; }
        public string AdminComment { get; set; }
        public string UserComment { get; set; }
        public long? CurrentLoanInformationId { get; set; }
        [NotMapped]
        public IEnumerable<long> ComponentIdsList { get; set; }
        public string ComponentIds
        {
            get { return string.Join(',', ComponentIdsList); }
            set
            {
                var tempValue = value.Split(',');
                var fin = new List<long>();

                foreach (var val in tempValue)
                {
                    fin.Add(Int32.Parse(val));
                }

                ComponentIdsList = fin;
            }
        }
    }
}
