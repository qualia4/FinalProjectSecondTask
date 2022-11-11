namespace FinalProjectSecondTask;

public class Parrot : Animal
{
    private string name;
    private string birthDate;
    private double weight;

    public Parrot(string name, string date, double weight)
    {
        name = this.name;
        date = birthDate;
        weight = this.weight;
    }

    public void say()
    {
        Console.WriteLine("Hello!");
    }
}