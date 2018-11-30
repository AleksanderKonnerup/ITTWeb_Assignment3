using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Models
{
    public class ESImage
    {
        [Key]
        public long ESImageId { get; set; }
        [MaxLength(128)]
        public string FileName { get; set; }
        public string ImageMimeType { get; set; }
        public byte[] ImageData { get; set; }
    }

    public enum ComponentTypeStatus
    {
        Available,
        ReservedAdmin
    }
}
