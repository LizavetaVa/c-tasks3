Console.WriteLine("Введите число N: ");
bool x = true;
int i = 1;

while (x)
{
    int N = int.Parse(Console.ReadLine()!); 

    if(N > 1)
    {
        for (i = 1; i < N; i++)
    {
        Console.Write(Math.Pow(i, 3) + " , ");
        x = false;
    }
    }

    else
    {
        Console.WriteLine("N должно быть больше 1, введите его еще раз: ");
    }
}
Console.Write(Math.Pow(i, 3));