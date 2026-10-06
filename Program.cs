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


string[] students = {"Аня", "Ярослав", "Вика"};
int number = 1;

foreach (string student in students)
{
    Console.WriteLine($"{number} . {student}");
    number++;
}