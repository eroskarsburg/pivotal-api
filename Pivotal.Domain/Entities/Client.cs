namespace Pivotal.Domain.Entities
{
    public class Client
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string Gender { get; set; } = "Other";
        public int Age { get; set; } = 0;
    }
}
