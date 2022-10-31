
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

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
        p6();
    }
    if (ui == 7)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p7();
    }
    if (ui == 8)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p8();
    }
    if (ui == 9)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p9();
    };
    if(ui == 10)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p10();
    }
    if (ui == 11)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p11();
    }
    if (ui == 12)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p12();
    }
    if (ui == 13)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p13();
    }
    if (ui == 14)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p14();
    }
    if (ui == 15)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p15();
    }
    if (ui == 16)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p16();
    }
    if (ui == 17)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p17();
    }
    if (ui == 18)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p18();
    }
    if (ui == 19)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p19();
    }
    if (ui == 20)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p20();
    }
    if (ui == 21)
    {
        Console.WriteLine($"Ati accesat problema {ui}");
        p21();
    }

void p21()
{
    int n=int.Parse(Console.ReadLine());
    while()
}

void p20()
{
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    int parteInt, parteFract;
    parteInt = m / n; 
    parteFract = m % n; 
    Console.Write($"{parteInt},");
    int cifra, rest;
    List<int> resturi = new List<int>();
    List<int> cifre = new List<int>();
    resturi.Add(parteFract);
    bool periodic = false;
    do
    {
        cifra = parteFract * 10 / n;
        cifre.Add(cifra);
        rest = parteFract * 10 % n;
        if (!resturi.Contains(rest))
        {
            resturi.Add(rest);
        }
        else
        {
            periodic = true;
            break;
        }
        parteFract = rest;
    } while (rest != 0);

    if (!periodic)
    {
        foreach (var item in cifre)
        {
            Console.Write(item);
        }
    }
    else
    {
        for (int i = 0; i < resturi.Count; i++)
        {
            if (resturi[i] == rest)
            {
                Console.Write("(");
            }
            Console.Write(cifre[i]);
        }
        Console.WriteLine(")");
    }
}

void p19()
{
    int n=int.Parse(Console.ReadLine());
    int[] a = new int[10];
    int nr = 0;
    while (n > 0)
    {
        a[n % 10]++;
        n /= 10;
    }
    for (int i= 0; i <= 9; i++)
    {
        if (a[i] != 0)
        {
            nr++;
        }
    }
    if (nr == 2)
    {
        Console.WriteLine($"Numarul este format din {nr} cifre");
    }
    else
        Console.WriteLine($"Numarul este format din {nr} cifre");
}

void p18()
{
    int n=int.Parse(Console.ReadLine());
    int d = 2;
    while (n > 1)
    {
        int p = 0;
        while (n % d == 0)
        {
            p++;
            n /= d;
        }
        if (p != 0)
            Console.WriteLine($"{d}^{p}");
        d++;
        if((n>1 && d * d > n))
        {
            d = n;
        }
    }
}

void p17()
{
    int n=int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    int a = n, b = m;
    while (n != m)
        if (n > m)
            n -= m;
        else
            m -= n;
    Console.WriteLine($"Cel mai mare divizor comun este: {n}");
    n = a; m = b;
    while(a != b)
    {
        if (a < b)
        {
            a = a + n;
        }
        if(a > b)
        {
            b = b + m;
        }
    }
    Console.WriteLine($"Cel mai mare multiplu comun este:{a}");
}

void p16()
{
    int a=int.Parse(Console.ReadLine());
    int b=int.Parse(Console.ReadLine());
    int c=int.Parse(Console.ReadLine());
    int d=int.Parse(Console.ReadLine());
    int e=int.Parse(Console.ReadLine());
    int aux = 0;
    if (a > b)
    {
        aux = a;
        a = b;
        b = aux;
    }
    if (a > c)
    {
        aux = a;
        a = c;
        c = aux;
    }
    if (a > d)
    {
        aux = a;
        a = d;
        d = aux;
    }
    if (a > e)
    {
        aux = a;
        a = e;
        e = aux;
    }
    if (b > c)
    {
        aux = b;
        b = c;
        c = aux;
    }
    if (b > d)
    {
        aux = b;
        b = d;
        d = aux;
    }
    if (b > e)
    {
        aux = b;
        b = e;
        e = aux;
    }

    if (c > d)
    {
        aux = c;
        c = d;
        d = aux;
    }
    if (c > e)
    {
        aux = c;
        c = e;
        e = aux;
    }
    if (d > e)
    {
        aux = d;
        d = e;
        e = aux;
    }
    Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
}

void p15()
{
    int a = int.Parse(Console.ReadLine());
    int b=int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int aux = 0;
    if (a > b )
    {
        aux = a;
        a = b;
        b = aux;
    }
    if (b > c)
    {
        aux = b;
        b = c;
        c = aux;
    }
    Console.WriteLine(a + " " + b + " " + c);
}

void p14()
{
    int n=int.Parse(Console.ReadLine());
    int inv = 0;
    int a = n;
    while (n != 0)
    {
        inv = inv * 10 + n % 10;
        n=n/ 10;
    }
    if (inv == a)
    {
        Console.WriteLine("Numarul este palindrom");
    }
    else
        Console.WriteLine("Numarul nu este palindrom");
}

void p13()
{
    int y1=int.Parse(Console.ReadLine());
    int y2=int.Parse(Console.ReadLine());
    int nr = 0;
    for(int i = y1; i <= y2; i++)
    {
        if (i % 4 == 0 && i % 100 != 0 && i%400!=0)
        {
            nr++;
        }
    }
    Console.WriteLine(nr);
}

void p12()
{
    int nr = 0;
    int a=int.Parse(Console.ReadLine());
    int b=int.Parse(Console.ReadLine());
    int n=int.Parse(Console.ReadLine());
    for(int i=a; i<=b;i++)
    {
        if (i % n == 0)
            nr++;
    }
    Console.WriteLine(nr);
}

void p11()
{
    int n = int.Parse(Console.ReadLine());
    while(n > 0)
    {
        Console.WriteLine(n % 10);
        n = n / 10;
    }
}

void p10()
{
    int n=int.Parse(Console.ReadLine());
    if (n == 2)
    {
        Console.WriteLine("Este prim");
    }
    if(n == 1)
    {
        Console.WriteLine("Nu este prim");
    }
    for (int d = 2; d <= Math.Sqrt(n); d++)
    {
        if (n % d == 0)
        {
            Console.WriteLine("Nu este prim");
        }
    }
}

void p9()
{
    int n = int.Parse(Console.ReadLine());
    for (int d = 2; d <= n; d++)
    {
        if (n % d == 0)
            Console.WriteLine(d);
    }
}

void p8()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    a = a + b;
    b = a - b;
    a = a - b;
    Console.WriteLine($"{a}, {b}");
}

void p7()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int aux = a;
        a = b;
        b = aux;
        Console.WriteLine($"{a}, {b}");
    }

void p6()
    {
        int a, b, c;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
    if (a + b > c && b + c > a && c + a > b)
    {
        Console.WriteLine($"Valorile {a}, {b}, {c} pot fi laturi ale unui triunghi");
    }
    else
        Console.WriteLine($"Valorile {a}, {b}, {c} NU pot fi laturile unui triunghi");
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