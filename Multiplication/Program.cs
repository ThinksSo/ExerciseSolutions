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
        for (int i = 1; i <= num; i++)
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
    int num = random.Next(2, 8);
    int count = 2;

    while (count < num + 1)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.Write($"{i} * {count} = {i * count} \t");
            // Печать столбиков рядом (актуально для значений до 8)
        }
        Console.WriteLine();
        count++;
    }
    Console.WriteLine();
}

Task8_1();
Task8_2();

