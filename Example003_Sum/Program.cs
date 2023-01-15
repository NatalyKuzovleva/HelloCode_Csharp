// Написать программу на языке C#,
// для Windows и Mac OS,
// [в которую пользователь вводит два целых числа]
// [в которой записаны два целых числа]
// [два целых числа генерируются случайным образом]
// и получает сумму

// Вариант 1
// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);

// Вариант 2
// int numberA = 31;
// int numberB = 58;
// int result = numberA + numberB;
// Console.WriteLine(result);

// Вариант 3
int numberA = new Random().Next(1, 10);   // 1, 2, 3, 4, ... 9
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberA);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
//Console.WriteLine($"Сумма чисел {numberA} и {numberB} равна {numberA + numberB}");

// Мой вариант
// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine($"Сумма двух чисел равна {number1 + number2}");
// Console.WriteLine($"Сумма чисел {number1} и {number2} равна {number1 + number2}");