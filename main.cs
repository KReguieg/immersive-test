public static string name = "Khaled"
public static string lastname = "Reguieg"

static void Main(string[] args)
{
    Console.WriteLine($"Hello my name is {name} {lastname}.");
    Console.WriteLine("Enter your favorite anime:");
    string favAnime = Console.ReadLine();
    Console.WriteLine($"Cool! I love {favAnime}! <3")
}