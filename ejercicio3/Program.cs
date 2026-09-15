Console.WriteLine("=== Quest Logic Tests ===");

Console.WriteLine(
    $"CanFastAttack(false): {QuestLogic.CanFastAttack(false)}");

Console.WriteLine(
    $"CanFastAttack(true): {QuestLogic.CanFastAttack(true)}");

Console.WriteLine(
    $"CanSpy(false, false, true): {QuestLogic.CanSpy(false, false, true)}");

Console.WriteLine(
    $"CanSpy(false, false, false): {QuestLogic.CanSpy(false, false, false)}");

Console.WriteLine(
    $"CanSignalPrisoner(false, true): {QuestLogic.CanSignalPrisoner(false, true)}");

Console.WriteLine(
    $"CanSignalPrisoner(true, true): {QuestLogic.CanSignalPrisoner(true, true)}");

Console.WriteLine(
    $"CanFreePrisoner(false, false, true, false): {QuestLogic.CanFreePrisoner(false, false, true, false)}");

Console.WriteLine(
    $"CanFreePrisoner(true, false, false, true): {QuestLogic.CanFreePrisoner(true, false, false, true)}");