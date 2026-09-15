class Program
{
    static void Main()
    {
        Lasagna lasagna = new Lasagna();

        Console.WriteLine(lasagna.ExpectedMinutesInOven());
        Console.WriteLine(lasagna.RemainingMinutesInOven(10));
        Console.WriteLine(lasagna.PreparationTimeInMinutes(3));
        Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
    }
}