namespace API.Domain
{
    public class Ship
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Code { get; set; } = String.Empty;
        public decimal Length { get; set; }
        public decimal Width { get; set; }
    }
}
