// базовый класс 
using NUnit.Framework.Internal;
using static System.Net.Mime.MediaTypeNames;

Animall animal = new Animall("Корова",  1);
Cat cat = new Cat("Пушистик", 1, "Золотистиый");
Dog dog = new Dog("Вольт", 3);

animal.Show(); animal.Voice();
cat.Show(); cat.Voice();
dog.Show(); dog.Voice();
public class Animall
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Animall(string name, int? age)
    {
        Name = name;
        // если указали возраст животного
        Age = age.HasValue ? age.Value : 0;
    }

    public void Show()
    {
        Console.WriteLine($"Животное по кличке: {Name}. Возраст: {(Age != 0 ? $"{Age} год" : "Не указан")}");
    }

    public void Voice()
    {
        Console.WriteLine("Мычание");
    }
}

public class Dog : Animall
{
    public Dog(string name, int? age) : base(name, age)
    {
        Name = name;
        // Age = age.HasValue ? age.Value : 0;
    }

    public void Show()
    {
        Console.WriteLine($"Собака по кличке: {Name}. Возраст: {(Age != 0 ? $"{Age} год" : "Не указан")}");
    }

    public void Voice()
    {
        Console.WriteLine("Гав-Гав");
    }
}

public class Cat : Animall
{
    public string Color { get; set; }

    public Cat(string name, int? age, string color) : base(name, age)
    {
        Color = color;
    }

    public void Show()
    {
        Console.WriteLine($"Кошка по кличке: {Name} и цветом {Color}. Возраст: {(Age != 0 ? $"{Age} год" : "Не указан")}");
    }

    public void Voice()
    {
        Console.WriteLine("Мяу-Мяу");
    }
}