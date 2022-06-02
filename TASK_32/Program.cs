/*
Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
{
    collection[index] = new Random().Next(-9, 10);
}
}

void printArray(int[] col)
{
    Console.Write("[");
    for (int position = 0; position < col.Length; position++)
    {
        if (position < col.Length - 1)
        {
            Console.Write($"{col[position]}, ");
        }
        else
        {
            Console.Write(col[position]);
            break;
        }
    }
    Console.Write("]");
}

int[] array1 = new int[4];
FillArray(array1);
printArray(array1);

void Negative(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = Array[i] * -1;
    }
}
Negative(array1);
Console.WriteLine();
Console.WriteLine("Перевертыш");
printArray(array1);
