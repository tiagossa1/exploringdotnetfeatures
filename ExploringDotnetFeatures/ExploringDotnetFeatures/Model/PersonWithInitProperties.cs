namespace ExploringDotnetFeatures.Model;

public class PersonWithInitProperties
{
    public Guid Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }

    // .NET 6 has finally introduced a DateOnly type. It is super useful when a developer only intends to use the Date part of DateTime for example. 
    public DateOnly DateOfBirth { get; init; }
    public DateTime CreatedAt { get; } = DateTime.UtcNow;

    public override string ToString()
    {
        return $"First Name: {FirstName}; Last Name: {LastName}, Full Name: {FirstName} {LastName}, Date of Birth: {DateOfBirth}, Created At: {CreatedAt}.ß";
    }
}