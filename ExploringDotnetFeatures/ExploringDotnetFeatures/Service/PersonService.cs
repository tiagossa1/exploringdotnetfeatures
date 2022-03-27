using ExploringDotnetFeatures.Interface;
using ExploringDotnetFeatures.Model;

namespace ExploringDotnetFeatures.Service;

public class PersonService : IPersonService
{
    // New way of initialize an object.
    private readonly List<string> _names = new()
    {
        "Ayva Duffy",
        "Saskia Forster",
        "Jozef Fritz",
        "Callam Baird",
        "Estelle Holland",
        "Harriet Romero",
        "Aneeka Chavez",
        "Bertha Bray",
        "Viktoria Santiago",
        "Cleo Goodwin"
    };
    
    public List<Person> GeneratePeople()
    {
        var people = new List<Person>();
        
        foreach (var personName in _names)
        {
            var nameSplitBySpace = personName.Split(" ");
            var year = RandomNumber(1900, DateTime.Now.Year);
            var month = RandomNumber(1, 12);
            var day = RandomNumber(1, 28);
            
            people.Add(new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = nameSplitBySpace[0],
                LastName = nameSplitBySpace[1],
                DateOfBirth = new DateOnly(year, month, day)
            });
        }

        return people;
    }

    public List<PersonWithInitProperties> GeneratePeopleWithInitProperties()
    {
        var people = new List<PersonWithInitProperties>();

        foreach (var personName in _names)
        {
            var nameSplitBySpace = personName.Split(" ");
            var year = RandomNumber(1900, DateTime.Now.Year);
            var month = RandomNumber(1, 12);
            var day = RandomNumber(1, 28);
            
            people.Add(new PersonWithInitProperties()
            {
                Id = Guid.NewGuid(),
                FirstName = nameSplitBySpace[0],
                LastName = nameSplitBySpace[1],
                DateOfBirth = new DateOnly(year, month, day)
            });
        }

        return people;
    }

    private int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}