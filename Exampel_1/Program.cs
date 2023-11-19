// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.Write(msg); // пишет в консоль параметр msg
    string num = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(num);// как результат преобразования строки в число 
    return number; // возврат из функции
}
void PrintNaturalNumbers(int startNum = 0, int endNum = 1) // Фукция вывода чётных натуральных чисел в указаном диапазоне
{
    if (startNum > endNum) // если вышли за верхий редел выходим из функции
    {
        return;
    }
    else if (startNum % 2 == 0) // если число четное выводим на экран 
    {
        Console.Write($"{startNum} ");
    }
    startNum++; // Увеличеваем нижнию границу на 1 (пепреходим к следующему числу)
    PrintNaturalNumbers(startNum, endNum); // Вызываем функцию со следующим значением

}
int startNumber = ReadInt("Введите началье число - "); 
int endNumber = ReadInt("Введите конечное число - ");
PrintNaturalNumbers(startNumber, endNumber);
