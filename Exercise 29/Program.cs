
Console.WriteLine("Программа создает массив на восемь элементов со случайными значениями (от 1 до 99).");

int[] array = new int[8];

void CreatArray(int[] collection)
{
    int lenth = 8;  // В условии задачи указана 8 как размер массива, но у меня не срабатывало определение "collection.Lenth".
    int index = 0;

    while (index < lenth)
    {
        array[index] = new Random().Next(1, 99);
        index++;
    } 
}

void PrintArray(int[] arrayPrint)
{
    int lenthPrint = 8;     // "arrayPrint.Lenth" здесь тоже не работает.
    int indexPrint = 0;
    while (indexPrint < lenthPrint)
    {
        if (indexPrint == 0)
        {
            Console.Write("[");
        }

        Console.Write(arrayPrint[indexPrint]);
        if (indexPrint < lenthPrint - 1) 
        {
            Console.Write(", ");
        }

        if (indexPrint == lenthPrint - 1)
        {
            Console.Write("]");
        }
        indexPrint++;
    }
}

CreatArray(array);
PrintArray(array);