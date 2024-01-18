var p1 = new Person("Hyechan", "Bang", new DateOnly(1993, 11, 8));
var p2 = new Person("Peter", "Parker", new DateOnly(1970, 5, 12));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [p1, p2];

foreach (var person in people) {
    Console.WriteLine($"{person}");
    foreach (Pet pet in person.Pets) {
        Console.WriteLine($"{pet}");
    }
}

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First {get {return firstname;}}
    public string Last {get {return lastname;}}
    public DateOnly Birthday {get {return birthday;}}

    public List<Pet> Pets {get;} = [];

    public override string ToString()
    {
        return $"{First} {Last}";
    }
}

public abstract class Pet(string firstname) {
    public string First {get;} = firstname;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"└ My name is {First} and I'm a {GetType().Name}. I {MakeNoise()}!";
    }
}

public class Cat(string firstname) : Pet(firstname) {
    public override string MakeNoise(){return "meow";}
}

public class Dog(string firstname) : Pet(firstname) {
    public override string MakeNoise() => "bark";
}