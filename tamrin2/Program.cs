

using static System.Runtime.InteropServices.JavaScript.JSType;

int s = 0, f = 0 , n =0;

Console.WriteLine("please enter first number");
string sstring = Console.ReadLine();
s = Convert.ToInt32(sstring);
Console.WriteLine("please enter srcound number");
string fstring = Console.ReadLine();
f = Convert.ToInt32(fstring);
f = Math.Abs(f);
s = Math.Abs(s);    
int revers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result * 10 + number % 10;
        number /= 10;
    }
    return result;
}
for (int i = s; i < f; i++)
{

    int x, a1;
    x = i;
    n = 1;
    a1 = i;
    double a1n, a2n;
    int ra1=a1 , ra2 , rra2;
    while (true)
    {
        if (x / 10 == 0)
        {
            break;
        }
        x = x / 10;
        n++;
    }
    
    if (n % 2 == 0)
    {
        a1n = n / 2;
        a2n = n / 2;
    }
    else
    {
        a1n = (n / 2) + 1;
        a2n = n / 2;
    }

    int p1 = 10, p2 = 10 ;
   for (int j = 1; j < a1n; j++)
    {
        p1 = p1 * 10;
    }
    for (int j = 1; j < a2n; j++)
    {
        p2 = p2 * 10;
    }
    if(ra1<10)
        Console.WriteLine(i);
    ra2 = ra1;
    ra1 = ra1 / p1;
    ra2 = ra2 % p2 ;
    rra2 = revers(ra2);
    if(rra2 == ra1)
        Console.WriteLine(i);
}