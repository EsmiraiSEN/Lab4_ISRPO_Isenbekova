// Console.WriteLine("Привет!");
// Console.WriteLine("ФИО: Исенбекова Эсмира");

// Console.WriteLine("Группа: ИСП-241");
// Console.WriteLine("Дата: " + DateTime.Now);

// Console.WriteLine("1 — Показать ФИО");
// Console.WriteLine("2 — Показать группу");
// Console.WriteLine("3 — Показать дату");
// Console.WriteLine("4 — Выход");

Console.WriteLine("Привет!");
Console.WriteLine("ФИО: Исенбекова Эсмира Максутовна");
Console.WriteLine("Группа: ИСП-241");
Console.WriteLine("Дата: " + DateTime.Now);

bool programma = true;
while (programma)
{
    Console.WriteLine("\n1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.Write("Выбор: ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1": Console.WriteLine("ФИО: Исенбекова Эсмира Максутовна"); break;
        case "2": Console.WriteLine("Группа: ИСП-241"); break;
        case "3": Console.WriteLine($"Дата: {DateTime.Now}"); break;
        case "4": programma = false; break;
        default: Console.WriteLine("Неверный выбор"); break;
    }
}