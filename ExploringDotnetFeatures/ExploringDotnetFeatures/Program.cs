using ExploringDotnetFeatures.Interface;
using ExploringDotnetFeatures.Model;
using ExploringDotnetFeatures.Service;
using Microsoft.Extensions.DependencyInjection;

// ----------------------------------------------------------------
// Dependency injection on .NET 6 Console Application:
var serviceProvider = new ServiceCollection()
    .AddSingleton<IPersonService, PersonService>()
    .BuildServiceProvider();

var personService = serviceProvider.GetService<IPersonService>();

// ----------------------------------------------------------------

// ----------------------------------------------------------------
// Constant interpolated strings
// C# 10 allows you to create constant strings and use interpolation in them.
// ----------------------------------------------------------------
const string salutation = "Welcome";
const string message = $"{salutation}!";
Console.WriteLine(message);
// ----------------------------------------------------------------

// ----------------------------------------------------------------
// Null Parameter Checking
// SayMyName method has been guarded against null arguments. See the method below.
// ----------------------------------------------------------------
string noName = null;
string myName = "John";

try
{
    SayMyName(noName);
}
catch (Exception e)
{
    Console.WriteLine("An exception has been thrown due to ThrowIfNull method on SayMyName method: " + e.Message);
}

SayMyName(myName);
// ----------------------------------------------------------------

// ----------------------------------------------------------------
// Init property
// This object have init on their properties, which means that they cannot be modified after it was giving their initial values.
// ----------------------------------------------------------------
var peopleWithInitProps = personService.GeneratePeopleWithInitProperties();

// This code fails as FirstName prop has init.
// var firstPerson = peopleWithInitProps[0];
// firstPerson.FirstName = "Robert";
// ----------------------------------------------------------------

// ----------------------------------------------------------------
// Pattern Matching
// ----------------------------------------------------------------
// Searching objects by any property has becoming more easy and interesting.
// Let's search for any person that has "Ayva" as first name:
PersonWithInitProperties ayva = peopleWithInitProps.FirstOrDefault(person => person is {FirstName: "Ayva"});

// Starting with C# 9, it is possible to use the not keyword.
if (ayva is not null)
{
    Console.WriteLine(ayva.ToString());   
}

// This method will demonstrate how guard has change in C# 10.
void SayMyName(string name)
{
    ArgumentNullException.ThrowIfNull(name);
    Console.WriteLine($"Your name is: {name}.");
}