public class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return 40 - actualMinutesInOven;
    }

    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return numberOfLayers * 2;
    }

    public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)
    {
        return numberOfLayers * 2 + actualMinutesInOven;
    }
}