// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.Write(msg); // пишет в консоль параметр msg
    string num = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(num);// как результат преобразования строки в число 
    return number; // возврат из функции
}

int Akkerman(int m, int n) // функция Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

int m = ReadInt("Введите число M - "); 
int n = ReadInt("Введите число N - ");
Console.Write(Akkerman(m, n)); 