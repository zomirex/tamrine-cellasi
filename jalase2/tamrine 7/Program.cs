







/* تکلیف امیر حسین ناصح */

Console.WriteLine("please enter the string");
//string inpt = Console.ReadLine();
string inpt = "Hello, my phone number is 0123456789, my address is rue Voltaire 145.  \r\nthe number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any question \r\nthe number 012345678 is not valid anymore. Contact the number 0999999888 if you have any question \r\nOur customer care representatives are available to assist you 24 hours a day, 7 days a week on : 0000000000, 9999999999 and 0777778899 ";
string x = "";
for(int i = 0;i < inpt.Length;i++)
{
    int n = 0;
    if (inpt[i] == '0')
    {
        while (inpt[i] >= 48 && inpt[i] <= 57)
        {
            x = x + inpt[i];
            n++;
            i++;
           
        }
        if (n == 10)
        {
            int z = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int k = 0; k < 9; k++)
                {
                    if (x[j] != x[k])
                    {
                        z++;
                        break;
                        //Consol.WriteLine(z);
                    }

                }
            }
            //Console.WriteLine(z);
            //Console.WriteLine(x);
            if (z >5)
            {
            Console.WriteLine(x);
                
            }
                
        }
     
     x = "";
    }
}