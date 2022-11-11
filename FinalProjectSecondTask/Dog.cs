namespace FinalProjectSecondTask;

public class Dog : Animal
{
    private string name;
    private string birthDate;
    private double weight;

    public Dog(string name, string date, double weight)
    {
        name = this.name;
        date = birthDate;
        weight = this.weight;
    }

    public void say()
    {
        Console.WriteLine("Bark!");
    }
}