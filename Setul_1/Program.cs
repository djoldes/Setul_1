
using System.Net.NetworkInformation;

int ui;
Console.WriteLine("Introduceti numarul problemei:"); 
ui =int.Parse(Console.ReadLine());
    if (ui == 1)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p1();
    }
    if (ui == 2)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p2();
    }
    if(ui == 3)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p3();
    }
    if (ui == 4)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p4();
    }
    if (ui == 5)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p5();
    }
    if (ui == 6)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
    }

void p5()
{
    int n, k, a, m, j;
    n = int.Parse(Console.ReadLine());
    k = int.Parse(Console.ReadLine());
    m = n;
    j = k;
    while (k > 1)
    {
        n = n / 10;
        k--;
    }
    if(k <= 1)
    {
        a = n % 10;
        Console.WriteLine($"A {j}-a cifra a lui {m} este {a}");
    }
}

void p4()
{
    int y;
    y = int.Parse(Console.ReadLine());
    if (y % 4 == 0 && y % 100 != 0)
    {
        Console.WriteLine($"Anul {y} este bisect");
    }
    else
        Console.WriteLine($"Anul {y} nu este bisect");
}

void p3()
{
    int n, k;
    n = int.Parse(Console.ReadLine());
    k = int.Parse(Console.ReadLine());
    if (n % k == 0)
    {
        Console.WriteLine("n se divide cu k");
    }
    else
        Console.WriteLine("n nu se divide cu k");
}

void p2()
{
    float a, b, c;
    a=float.Parse(Console.ReadLine());
    b=float.Parse(Console.ReadLine());
    c=float.Parse(Console.ReadLine());
    float d, x1, x2 ;
    d = b * b - 4 * a * c;
    if (d >= 0)
    {
        x1 = (-b - (float)Math.Sqrt(d)) / (2 * a);
        x2 = (-b + (float)Math.Sqrt(d)) / (2 * a);
        Console.WriteLine(x1 + " " + x2);
    }
    else
        Console.WriteLine("Ecuatia nu are solutii");
}

void p1()
{
    float a, b;
    a = float.Parse(Console.ReadLine());
    b = float.Parse(Console.ReadLine());
    float x;
    x = -b / a;
    Console.WriteLine(x);
}