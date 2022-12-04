// Задача: 
// Написать программу сложения и вычитания двух многочленов




// f(x) =  1*x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4+ 16*x^5
// g(x) =  10*x^0 + 11*x^1 + 4*x^2 

int[] Sum(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] + g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}

int[] Diff(int[] f, int[] g)
{
    int numF = f.Length;
    int numG = g.Length;
    int resMax = numF;
    int resMin = numG;
    if(numG > resMax)
    {
        resMax = numG;
        resMin = numF;
    }
    int[] res = new int[resMax];
    for(int i = 0; i < resMin; i++)
    {
        res[i] = f[i] - g[i];
    }
    for(int i = resMin; i < resMax; i++)
    {
        if(resMax == numG) res[i] = g[i];
        else res[i] = f[i];
    }
    return res;
}

string Print(int[] f)
{
  string output = String.Empty;
  for (int i = 0; i < f.Length; i++)
  {
    int t = f[i];
    if (f[i] == 0) continue;
    if (f[i] < 0) { output += " - "; }
    else if (i != 0) { output += " + "; }

    if (t < 0) t = -t;
    if (i == 1) { output += $"{t}x"; }
    if (i == 0) { output += $"{t}"; }
    if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x^{i}"; }
    //if (flag && f[i] != 0 && i < f.Length - 1) output += " + ";
  }

  return output;
}


//          0  1  2  3  4  5  6  7  ......... N

int[] f = { 4, 0, 0, 0, -9, -6, 8 };
//          1* x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4 + 6*x^5
// 

int[] g = { 1, -2, -5, 0, 0, 7, 3 };
Console.WriteLine(Print(f));
Console.WriteLine(Print(g));
int[] s = Sum(f, g);
Console.WriteLine(Print(s));
int[] d = Diff(f, g);
Console. WriteLine(Print(d));
//f(x) = a0*x^0 + a1*x^1 + a2*x^2 + a3*x^3 + a4*x^4 + ....+ aN*x^N



Console.WriteLine();

