using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRadarApi.DAL.Model
{
    public class Ring
    {
        [Key]
        [Required]
        public int RingId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Technology>? Technologies { get; set; }
    }
}
