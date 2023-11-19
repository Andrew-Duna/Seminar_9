// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.Write(msg); // пишет в консоль параметр msg
    string num = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(num);// как результат преобразования строки в число 
    return number; // возврат из функции
}
int SumNum(int startNum = 0, int endNum = 1) // Функция нахождния суммы всвех эиментов от startNum до endNum
{
    int result = startNum;
    if (result == endNum)
    {
        return result;
    }
    else
    {
        startNum++;
        result = result + SumNum(startNum, endNum);
    }
    return result;
}
int startNumber = ReadInt("Введите началье число - ");
int endNumber = ReadInt("Введите конечное число - ");
int result = SumNum(startNumber, endNumber);
Console.WriteLine(result);