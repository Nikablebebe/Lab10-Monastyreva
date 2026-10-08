// string subject = "Программирование";

// foreach (char letter in subject) {
//     Console.WriteLine(letter);
// }

// Console.WriteLine($"Всего букв: {subject.Length}");


// int[] grades = { 4, 5, 3, 5, 4 };
// int sum= 0;
// foreach (int grade in grades) {
//     Console.WriteLine(grade);
//     sum += grade;
// }
// int sb = sum / grades.Length;
// Console.WriteLine($"Всего оценок: {grades.Length}");
// Console.WriteLine($"Средний балл: {sb}");

//  string[] students = { "Аня", "Борис", "Вика" };
//  int count = 0;

// foreach (string student in students)
// {
//     count++;
// }

// Console.WriteLine($"Всего учеников: {count}");


// int[] numbers = { 10, 20, 15 };

// for (int i = 0; i < numbers.Length; i++) {
//     numbers[i] = numbers[i] + 5;
// }

// foreach (int n in numbers) {
//     Console.WriteLine(n);
// }


// string[] students = {"Аня", "Борис", "Вика"};
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number} . {student}");
//     number++;
// }

// Задача А

// int[] num = { 1, 4, 13, 33, 67};
// int sum = 0;

// foreach (int n in num)
// {
//     Console.WriteLine(n);
//     sum += n;
// }
// Console.WriteLine($"Сумма: {sum}");

// Задача Б

// string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

// foreach (string d in days)
// {
//     Console.WriteLine($"{d}!");
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

// ВАРИАНТ 5

// string[] books = {"Белые ночи", "Дневник памяти", "Тюремная исповедь", "Сентябрьские розы"};

// Console.WriteLine("Введите название книги для поиска:");
// string search = Console.ReadLine();

// bool found = false;

// foreach (string book in books)
// {
//     if (book == search)
//     {
//         found = true;
//     }
// }
// if (found)
// {
//     Console.WriteLine("найдено");
// } else
// {
//     Console.WriteLine("Не найдено");
// }

// ВАРИАНТ 7

using System.Linq.Expressions;

int[] grades = { 5, 4, 2, 3, 4, 5, 3, 4, 5, 2, 4, 4, 4};
int count = 0;

foreach (int grade in grades)
{
    if (grade == 5)
    {
        count++;
    }
}

Console.WriteLine($"Количество пятерок: {count}");