// int totalExercises = 8;

// for (int number = totalExercises; number >= 1; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("_");
// }


// int skippedCount = 0;

// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         skippedCount++;
//         continue;
//     }

//     Console.WriteLine($"Первый доступный билет: {ticket}, пропущено билетов: {skippedCount}");
//     break;
// }


// // for (; ; )
// // {
// //     Console.Write("Введите код группы (для выхода - «выход»): ");
// //     string groupCode = Console.ReadLine();

// //     if (groupCode == "выход")
// //     {
// //         break;
// //     }

// //     Console.WriteLine($"Записан код группы: {groupCode}");
// // }

// // Console.WriteLine("Работа с журналом завершена");

// //самостоятельные задания 
// //задача а
// int N = 20;
// Console.WriteLine($"Нечетные числа от 1 до {N}:");
// for (int i = 1; i <= N; i++) {
//     if (i % 2 != 0) {
//         Console.WriteLine(i);
//     }
// }

// //задача в
// Console.WriteLine("Таблица умножения от 1 до 9:");
// for (int i = 1; i <= 9; i++)
// {
//     for (int j = 1; j <= 9; j++)
//     {
//         Console.WriteLine($"{i * j}\t");
//     }
//     Console.WriteLine();
// }

// //задача б
// Console.WriteLine("Числа от 100 до 0 с шагом -10: ");
// for (int i = 100; i >= 0; i-=10) {
//     Console.WriteLine(i);
// }

// //задача г
// Console.WriteLine("Перебор чисел от 1 до 50: ");
// for (int i = 1; i <= 50; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     if (i % 7 == 0)
//     {
//         Console.WriteLine($"Первое число, кратное 7 {i}. Остановка цикла (break).");
//         break;
//     }
//     Console.WriteLine(i);
// }

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

//индивидуальные задания
//буничева №1 и №5
//№1
int N = 30;

Console.WriteLine($"Числа от 1 до {N}, кратные 3: ");
for (int i = 1; i <= N; i++)
{
    if (i % 3 == 0) {
        Console.WriteLine(i);
    }
}
//№5
Console.WriteLine("Поиск первого числа от 1 до 100, кратного 3 и 5 одновременно: ");

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) {
        Console.WriteLine($"Найдено число: {i}");
        break;
    }
}

//Василенко №5 и №8
//№5
Console.WriteLine("Поиск первого числа от 1 до 100, кратного 3 и 5 одновременно: ");

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) {
        Console.WriteLine($"Найдено число: {i}");
        break;
    }
}
//№8
Console.WriteLine("Четные числа от 100 до 2 в обратном порядке: ");
for (int i = 100; i >= 2; i -= 2) {
    Console.WriteLine(i);
}