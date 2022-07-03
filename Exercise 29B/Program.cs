// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Вариант решения с вводом размера массива.
Console.WriteLine("Программа создает массив на указанное число элементов со случайными значениями (от 1 до 99).");
Console.Write("Укажите размер массива: ");
Console.WriteLine(" ");

int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

void CreatArray(int[] collection)
{
    int index = 0;

    while (index < number)
    {
        array[index] = new Random().Next(1, 99);
        index++;
    } 
}

void PrintArray(int[] arrayPrint)
{
    int indexPrint = 0;

    while (indexPrint < number)
    {
        if (indexPrint == 0)
        {
            Console.Write("[");
        }

        Console.Write(arrayPrint[indexPrint]);

        if (indexPrint < number - 1) 
        {
            Console.Write(", ");
        }

        if (indexPrint == number - 1)
        {
            Console.Write("]");
        }
        indexPrint++;
    }
}

CreatArray(array);
PrintArray(array);
