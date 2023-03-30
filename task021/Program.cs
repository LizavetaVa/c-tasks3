Console.WriteLine("Введите координату X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z1: ");
int z2 = int.Parse(Console.ReadLine());

double sqr1 = Math.Pow((x1 - x2), 2);
double sqr2 = Math.Pow((y1 - y2), 2);
double sqr3 = Math.Pow((z1 - z2), 2);

Console.WriteLine(Math.Round(Math.Sqrt(sqr1 + sqr2 + sqr3), 2));
