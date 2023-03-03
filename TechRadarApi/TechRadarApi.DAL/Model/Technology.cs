using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRadarApi.DAL.Model
{
    public class Technology
    {
        [Key]
        [Required]
        public int TechnologyId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string? Explanation { get; set; }

        public int? RingId { get; set; }
        public Ring? Ring { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public bool IsPublished { get; set; }
    }
}
