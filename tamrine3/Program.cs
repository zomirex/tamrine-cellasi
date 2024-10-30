/* تمرین 3 توضیحات فیبوناچی */
Console.WriteLine("please enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int a1 = 0, a2 =1 ,l=0 ;
l = a1 + a2;
while (l <= n)
{
    if (l == n)
    {
        Console.WriteLine(n + "  thats available");
        break;
    }
    a1 = l;
    l = l+a2;
    a2 = a1;

}
if (l > n)
    Console.WriteLine("number "+n+" is'nt available");
