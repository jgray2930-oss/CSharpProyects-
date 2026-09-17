int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };var birdCount = new BirdCount(birdsPerDay);

Console.WriteLine(string.Join(", ", BirdCount.LastWeek()));
Console.WriteLine(birdCount.Today());
birdCount.IncrementTodaysCount();
Console.WriteLine(birdCount.Today());
Console.WriteLine(birdCount.HasDayWithoutBirds());
Console.WriteLine(birdCount.CountForFirstDays(4));
Console.WriteLine(birdCount.BusyDays());