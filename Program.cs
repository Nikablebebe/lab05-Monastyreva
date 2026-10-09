// int dayNumber = 5;

// switch (dayNumber) {
//     case 5:
//     case 6 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }

// int score = 78;

// switch (score) {
//     case >= 0 and <= 39:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and <= 59:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and <= 79:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }

// int temperature = 20;

// string result = temperature switch {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     >= 35 => "Очень жарко"
// };

// Console.WriteLine(result);

// string role = "user";

// string result = role switch {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     _ => "Ограниченный доступ"
// };

// Console.WriteLine(result);

// int age = 20;
// bool hasTicket = true;

// switch (age) {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }

// int level = 2;

// switch (level) {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }

//ЗАДАЧА А

// Console.Write("Введите номер месяца (1-12): ");
// int month = int.Parse(Console.ReadLine());

// string season = month switch {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine(season);

//ЗАДАЧА Б

// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine());

// string category = age switch {
//     < 0 => "Ошибка",
//     >= 0 and <= 6 => "Ребёнок",
//     >= 7 and <= 17 => "Подросток",
//     >= 18 and <= 64 => "Взрослый",
//     >= 65 => "Пенсионер"
// };

// Console.WriteLine(category);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


//ВАРИАНТ 1

// Console.Write("Введите номер месяца (1-12): ");
// int month = int.Parse(Console.ReadLine());
// string season = month switch {
//             12 or 1 or 2 => "Зима",
//             3 or 4 or 5 => "Весна",
//             6 or 7 or 8 => "Лето",
//             9 or 10 or 11 => "Осень",
//             0  => "Неверный месяц"
//         };

//         Console.WriteLine(season);

//ВАРИАНТ 4

Console.Write("Введите размер напитка (S, M, L): ");
string size = Console.ReadLine();

int price = size switch {
    "S" => 150,
    "M" => 200,
    "L" => 250,
    "0" => -1
};

if (price == -1)
{
    Console.WriteLine("Неизвестный размер");
}
else
{
    Console.Write("Есть студенческая скидка? (да/нет): ");
    string discountInput = Console.ReadLine();

    if (discountInput == "да")
    {
        price = price - (price / 10);
    }

    Console.WriteLine($"Стоимость: {price} руб.");
}