namespace TechRadarApi.BL.Data
{
    public class TechnologyDTO
    {
        public int? TechnologyId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Explanation { get; set; }
        public int? RingId { get; set; }
        public int CategoryId { get; set; }
        public bool IsPublished { get; set; }
    }
}
