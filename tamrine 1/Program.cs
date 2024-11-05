





/* تکلیف امیر حسین ناصح */


/* توضیحات 
 tamrin 1 */

int s = 0, f = 0;
Console.WriteLine("please enter first number");
string sstring = Console.ReadLine();
s = Convert.ToInt32(sstring);
Console.WriteLine("please enter srcound number");
string fstring = Console.ReadLine();
f = Convert.ToInt32(fstring);
Console.WriteLine("result:              ");
for (int i = s; i < f; i++)
{
    int x = i, y = 2;
    while (true)
    {
        if (x == y)
        {
            Console.WriteLine(x);
            break;
        }
        else if (x % y == 0)
            break;
        y++;
    }
}