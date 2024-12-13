using System;

// Superclass: Person
class Person
{
    public string Name;
    public int Age;
    public string Address;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Hello!");
    }

    public void Walk()
    {
        Console.WriteLine($"{Name} is walking.");
    }
}

// Subclass: Favorites
class Favorites : Person
{
    public string FavoriteFood;
    public string FavoriteColor;
    public string FavoriteHobby;

    public void DisplayFavorites()
    {
        Console.WriteLine($"Favorite Food: {FavoriteFood}, Favorite Color: {FavoriteColor}, Favorite Hobby: {FavoriteHobby}");
    }

    public void EnjoyHobby()
    {
        Console.WriteLine($"{Name} is enjoying their hobby: {FavoriteHobby}.");
    }

    public void EatFavoriteFood()
    {
        Console.WriteLine($"{Name} is eating their favorite food: {FavoriteFood}.");
    }
}

// Subclass: Status
class Status : Person
{
    public string HealthStatus;
    public string Mood;
    public string JobStatus;

    public void DisplayStatus()
    {
        Console.WriteLine($"Health: {HealthStatus}, Mood: {Mood}, Job Status: {JobStatus}");
    }

    public void ChangeMood(string newMood)
    {
        Mood = newMood;
        Console.WriteLine($"{Name}'s mood is now: {Mood}.");
    }

    public void UpdateJobStatus(string newJobStatus)
    {
        JobStatus = newJobStatus;
        Console.WriteLine($"{Name}'s job status is now: {JobStatus}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Person instance and use both subclasses
        Favorites favorites = new Favorites
        {
            Name = "Alice",
            Age = 25,
            Address = "123 Main St",
            FavoriteFood = "Pizza",
            FavoriteColor = "Blue",
            FavoriteHobby = "Painting"
        };

        Status status = new Status
        {
            Name = "Alice",
            Age = 25,
            Address = "123 Main St",
            HealthStatus = "Good",
            Mood = "Happy",
            JobStatus = "Employed"
        };

        // Display information using both subclasses
        favorites.DisplayInfo();
        favorites.DisplayFavorites();
        favorites.EnjoyHobby();

        status.DisplayStatus();
        status.ChangeMood("Excited");
        status.UpdateJobStatus("Promoted");
    }
}
