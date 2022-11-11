namespace FinalProjectSecondTask;

public class Cat : Animal
{
    private string name;
    private string birthDate;
    private double weight;

    public Cat(string name, string date, double weight)
    {
        name = this.name;
        date = birthDate;
        weight = this.weight;
    }

    public void say()
    {
        Console.WriteLine("Meow!");
    }
}