namespace TechRadarApi.BL.Data
{
    public class TechnologyDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Explanation { get; set; }
        public int? RingId { get; set; }
        public int CategoryId { get; set; }
    }
}
