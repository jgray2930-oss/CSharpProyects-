var lista = Languages.GetExistingLanguages();

Console.WriteLine(string.Join(", ", Languages.NewList()));
Console.WriteLine(string.Join(", ", lista));
Console.WriteLine(string.Join(", ", Languages.AddLanguage(lista, "VBA")));
Console.WriteLine(Languages.CountLanguages(lista));
Console.WriteLine(Languages.HasLanguage(lista, "Elm"));
Console.WriteLine(string.Join(", ", Languages.ReverseList(lista)));
Console.WriteLine(Languages.IsExciting(lista));
Console.WriteLine(string.Join(", ", Languages.RemoveLanguage(lista, "Clojure")));
Console.WriteLine(Languages.IsUnique(lista));