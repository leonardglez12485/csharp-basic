using System.Text.Json;

var leonard = new People("Leonardo", 39);

string json = JsonSerializer.Serialize(leonard);
Console.WriteLine(json);

string myJson = @"{
    ""Name"": ""Pepe"",
    ""Age"": 39
}";

People? person = JsonSerializer.Deserialize<People>(myJson);
if (person != null)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

public class People {
    public string Name { get; set; }
    public int Age {  get; set; }

    public People(string name, int age){
        Name = name;
        Age = age;
    }
}
