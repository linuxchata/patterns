using Monostate;

var person = new Person() { Name = "Oliver" };
var anotherPerson = new Person();

Console.WriteLine($"{person.Name} = {anotherPerson.Name}");

Console.ReadKey();
