// Написать программу умножения двух многочленов

int[] Mult(int[] f, int[] g, int a, int b)
{
    int[] result = new int[a + b - 1];
    for (int i = 0; i < a + b - 1; i++) result[i] = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++) result[i + j] = f[i] * g[j];
    }
    return result;
}

void PrintPol(int[] pol, int b)
{
    for (int i = 0; i < b; i++)
    {
        Console.Write(pol[i]);
        if (i != 0) Console.Write("x^" + 1);
        if (i != b - 1) Console.Write("+");
    }
}


int[] f = {3, 0, 7, 10};
int[] g = {1, 2, 5};
int a = f.Length;
int b = g.Length;

Console.WriteLine("Первый многочлен: ");
PrintPol(f, a);
Console.WriteLine("Второй многочлен: ");
PrintPol(g, b);

int[] res = Mult(f, g, a, b);

Console.WriteLine("Произведение многочленов: ");
PrintPol(res, a + b - 1);

