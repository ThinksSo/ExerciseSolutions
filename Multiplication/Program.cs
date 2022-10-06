//MULTIPLICATION - УМНОЖЕНИЕ

// Задача 8. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, 
// где n задаётся случайно от 2 до 30.
// Вариант 1.
void Task8_1()
{
    Console.WriteLine("\n \t Task 8: Multiplication table");
    Console.WriteLine();

    Random random = new Random();
    int num = random.Next(2, 30);
    int count = 2;

    while (count < num + 1)
    {
        for (int i = 2; i <= num; i++)
        {
            Console.WriteLine($"{count} * {i} = {i * count}");
        }
        Console.WriteLine();
        count++;
    }
    Console.WriteLine();
}

// Вариант 2.
void Task8_2()
{
    Console.WriteLine("\n \t Task 8: Multiplication table");
    Console.WriteLine();
    Random random = new Random();
    int num = random.Next(3, 9);
    int count = 2;

    while (count < num + 1)
    {
        for (int i = 2; i <= num; i++)
        {
            Console.Write($"{i} * {count} = {i * count} \t");
            // Печать столбиков рядом (актуально для значений до 8)
        }
        Console.WriteLine();
        count++;
    }
    Console.WriteLine();
}

// Метод для умножнеия до заданного числа
void Multiplication(int number)
{
    int count = 2;
    while (count < number + 1)
    {
        for (int i = 2; i <= number; i++)
        {
            Console.WriteLine($"{count} * {i} = {i * count}");
        }
        Console.WriteLine();
        count++;
    }
}

Task8_1();
Task8_2();
Multiplication(7); // любое значени до которого вывести таблицу умножения


