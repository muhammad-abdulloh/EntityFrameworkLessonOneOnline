namespace EntityFrameworkLessonOne.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string? Unit { get; set; }
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
