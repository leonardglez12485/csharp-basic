using System.Text.Json;
public class Person{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Heigth {get; set;}
    public double Weigth {get; set;}
    public string Address { get; set; }



    public Person(string name, int age, double heigth, double weigth, string address){
        Name = name;
        Age = age;
        Heigth = heigth;
        Weigth = weigth;
        Address = address; 
    }
}

public partial class Program {
    public static void Main() {
        var client = new Person("Leonard Gonzalez", 39, 1.78, 90, "Las Tunas ");
    }
}


// Compare this snippet from ConsoleApp/Program.cs: