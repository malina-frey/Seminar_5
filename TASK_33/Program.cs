/*
33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

bool DetectNumber(int[] array, int putNumber)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (putNumber == array[i])
        {
            result = true;
            break;
        }
    }
    return result;
}
int[] array1 = new int[4];
FillArray(array1);
printArray(array1);
bool HasNumber = DetectNumber(array1, 5);
Console.WriteLine((HasNumber)?"да":"нет");