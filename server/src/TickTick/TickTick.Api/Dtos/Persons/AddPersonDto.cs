namespace TickTick.Api.Dtos.Persons
{
    public record AddPersonDto
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
    }
}
