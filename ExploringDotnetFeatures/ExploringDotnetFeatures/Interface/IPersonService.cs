using ExploringDotnetFeatures.Model;

namespace ExploringDotnetFeatures.Interface;

public interface IPersonService
{
    List<Person> GeneratePeople();
    List<PersonWithInitProperties> GeneratePeopleWithInitProperties();
}