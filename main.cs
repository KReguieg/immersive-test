public static string name = "Khaled"
public static string lastname = "Reguieg"

public static string age = "34"

static void Main(string[] args)
{
    Console.WriteLine($"Hello my name is {name} {lastname}, I'm {age} years old.");
    Console.WriteLine("Enter your favorite anime:");
    string favAnime = Console.ReadLine();
    Console.WriteLine($"Cool! I love {favAnime}! <3\n")

    Console.WriteLine("Enter your favorite color:");
    string favColor = Console.ReadLine();
    Console.WriteLine($"Cool! {favColor} is an awesome color! <3")
}