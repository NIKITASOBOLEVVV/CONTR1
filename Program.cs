string[] array1 = new string[5] {"папа", "мать", "сын", "дочь", "я"};
string[] array2 = new string[array1.Length];
void letter3(string[] array1, string[] array2)
{
    int count = 0;//счетчик 
    for (int i = 0; i < array1.Length; i++)//бежим по 1 массиву 
    {
    if(array1[i].Length <= 3)//сортировка (если строка в масииве меньше или равна 3 то делай)
        {
        array2[count] = array1[i];//то во второй массив записывается строка 
        count++;// пеермещаемся к следующей строке массива
        }
    }
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
letter3(array1, array2);
Print(array2);
//создаем 2 массива одной длины, первый со строками, второй пустой. цикл бежим по первому массиву, все там сортировка по длинне
//все что меньше записывается во второй массив, счетчик переходит к следующему элементу 
//принт- выводим на экран второй массив 