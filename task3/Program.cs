//Задача 3
//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ShowArray (int [] array, int checksize)
{
    if (checksize > array.Length-1)
        return;
        
    if (checksize < array.Length)
    {
        ShowArray(array, checksize+1); 
        Console.Write (" " + array[checksize]);
    }
}
int [] array = new int [] {1, 2, 3, 4, 5, 6};
ShowArray (array, 0);