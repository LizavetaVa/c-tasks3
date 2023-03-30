Console.WriteLine("Введите пятизначиное число: ");
bool x = true;

while (x)
{
    int N = int.Parse(Console.ReadLine()!); 

    if (N > 9999 && N < 100000)
    {
        int a = N / 10000;
        Console.WriteLine("Первая цифра : " + a);

        int b = N / 1000 - a * 10;
        Console.WriteLine("Вторая цифра : " + b);

        int c = N / 100 - b * 10  - a * 100;
        Console.WriteLine("Третья цифра : " + c);

        int d = N / 10 - c * 10 - b * 100  - a * 1000;
        Console.WriteLine("Четвертая цифра : " + d);

        int e = N - d * 10 - c * 100 - b * 1000  - a * 10000;
        Console.WriteLine("Пятая цифра : " + e);


    if(a == e && b == d)
        Console.WriteLine($"Число {N} является палиндромом.");
    else
        Console.WriteLine($"Число {N} не является палиндромом.");
        x = false;
}

    else 
        Console.WriteLine($"Число {N} не является ппятизначным введите пятизначное.");
}