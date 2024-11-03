namespace NewsApi.Domain.Entities
{
    public class News
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Paragraph { get; set; }
    }
}