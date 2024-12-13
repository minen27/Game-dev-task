using System;

// Define the Animal class
class Animal
{
    // Private attributes
    private string Name;
    private string Breed;
    private int Age;

    // Constructor to initialize attributes
    public Animal(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }

    // Setters
    public void SetName(string name) => Name = name;
    public void SetBreed(string breed) => Breed = breed;
    public void SetAge(int age) => Age = age;

    // Getters
    public string GetName() => Name;
    public string GetBreed() => Breed;
    public int GetAge() => Age;

    // Bark method
    public virtual void Bark()
    {
        Console.WriteLine("Animal sound!");
        //This is a method in C# that writes a line of text to the console,
        //It automatically moves the cursor to the next line after printing the text.
    }
}

// Define the Dog class that inherits from Animal
class Dog : Animal
{
    // Additional private attribute
    private string FavoriteToy;

    // Constructor to initialize attributes, including those from the base class
    public Dog(string name, string breed, int age, string favoriteToy) : base(name, breed, age)
    {
        FavoriteToy = favoriteToy;
    }

    // Setter
    public void SetFavoriteToy(string favoriteToy) => FavoriteToy = favoriteToy;

    // Getter
    public string GetFavoriteToy() => FavoriteToy;

    // Override the Bark method
    public override void Bark()
    {
        Console.WriteLine($"{GetName()} says: Woof! Woof!");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Animal class
        Animal animal = new Animal("Generic Animal", "Unknown", 5);
        animal.SetName("Leo");
        animal.SetBreed("Mixed");
        animal.SetAge(7);

        // Create an instance of the Dog class
        Dog dog = new Dog("Buddy", "Golden Retriever", 3, "Rubber Ball");
        dog.SetFavoriteToy("Bone");

        // Call the Bark method for both objects
        animal.Bark();
        dog.Bark();

        // Print attributes of the Animal object
        Console.WriteLine("Animal Details:");
        Console.WriteLine($"Name: {animal.GetName()}");
        Console.WriteLine($"Breed: {animal.GetBreed()}");
        Console.WriteLine($"Age: {animal.GetAge()}");

        // Print attributes of the Dog object
        Console.WriteLine("\nDog Details:");
        Console.WriteLine($"Name: {dog.GetName()}");
        Console.WriteLine($"Breed: {dog.GetBreed()}");
        Console.WriteLine($"Age: {dog.GetAge()}");
        Console.WriteLine($"Favorite Toy: {dog.GetFavoriteToy()}");
    }
}
