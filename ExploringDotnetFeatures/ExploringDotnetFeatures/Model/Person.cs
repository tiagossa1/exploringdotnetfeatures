namespace ExploringDotnetFeatures.Model;

public class Person
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // .NET 6 has finally introduced a DateOnly type. It is super useful when a developer only intends to use the Date part of DateTime for example. 
    public DateOnly DateOfBirth { get; set; }
    public DateTime CreatedAt { get; } = DateTime.UtcNow;
}