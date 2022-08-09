void Zadacha25()
{
    //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    Console.WriteLine("Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.");
    Console.WriteLine("Введите число A");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int multiplier = 1;                    
    
    for (int i = 1; i <= numberB; i++)
    {
        multiplier = multiplier * numberA;
    }
    Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} равна {multiplier}");

}

Zadacha25();

void Zadacha27()
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int num = number;
    int sum = 0;    

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }               
    
    Console.WriteLine($"ПРоизведение цифр числа {number} равно {sum}.");

}

Zadacha27();


void Zadacha29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

    Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
    int size = 8;
    int[] array = new int[size];
    Random rand = new Random();
    Console.Write("Исходный массив: ");
    Console.WriteLine();
    for (int a = 0; a < size; a++) 
    {
         array[a] = rand.Next(-99, 99);  
         Console.Write($"{array[a]}, ");       
    }
    int temp;
    Console.WriteLine();
    Console.Write("Отсортированный массив: ");
    Console.WriteLine();
    for (int i = 0; i < size - 1; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[j]))
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
     
        }

   
    Console.Write($"{array[i]}, ");
   
    }
}

Zadacha29();