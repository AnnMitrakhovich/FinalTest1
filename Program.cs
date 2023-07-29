// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int InputSize(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
string[] CreatArrayStrings(int size)
{
    return new string[size];
}
void FillArrayStrings(string[] arrStr)
{
    string str = String.Empty;
    for (int i = 0; i < arrStr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        str = Convert.ToString(Console.ReadLine()!);
        arrStr[i] = str;
    }
}
void ReadArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
}
int FindThreeCharsInSrtring(string[] array)
{
    string findstring = String.Empty;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        findstring = array[i];
        if (findstring.Length <= 3) count++;
    }
    return count;
}
void FillNewArrayThreeCharsInString(string[] arrayOld, string[] arrayNew)
{
    string str = String.Empty;
    int count = 0;
    for (int i = 0; i < arrayOld.Length; i++)
    {
        str = arrayOld[i];
        if (str.Length <= 3)
        {
            arrayNew[count] = str;
            count++;
        }
    }
}
// получаем входной массив строк
int sizeArr = InputSize("введите количество строк: ");
string[] myArr = CreatArrayStrings(sizeArr);
FillArrayStrings(myArr);
ReadArray(myArr);
Console.WriteLine();
// Решение задачи. Находим длину нового массива.
int c = FindThreeCharsInSrtring(myArr);
Console.WriteLine(c);
Console.WriteLine();
// Создаем новый массив из строк, длина которых меньше, либо равна 3 символам.
string[] newArray = CreatArrayStrings(c);
// заполняем массив элементами из входного массива.
FillNewArrayThreeCharsInString(myArr, newArray);
// печатаем массив для проверки.
ReadArray(newArray);

