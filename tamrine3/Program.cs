







/* توضیحات 
 tamrin 3 */
using System.ComponentModel.Design;
Console.WriteLine("please press uper case or lower case letter");

char R = Console.ReadKey(true).KeyChar;

int r = R;
string result ="";
if (r >= 65 &&  r<= 90)
{
    result = result + R.ToString();
    
    
    

    Console.WriteLine("please press a number");
    R = Console.ReadKey(true).KeyChar;
    r = R;
    if (r >= 48 && r <= 57)
	{
        result = result + R.ToString();
        Console.WriteLine("please press A or B");
        R =Console.ReadKey(true).KeyChar;  
        if (R == 'A'|| R == 'a')
        {
            result = result + R.ToString();
            Console.WriteLine(result);
        }
            
        else if (R == 'B' || R == 'b')
        {
            result = result + R.ToString();
            Console.WriteLine(result);
        }
           

    }
}

else if (r >= 97 && r <= 122)
{
    result = result + R.ToString();
    
    
    Console.WriteLine("please press a number");
    R = Console.ReadKey(true).KeyChar;
   
    r = R;
    if (r >= 48 && r <= 57)
	{
        result = result + R.ToString();
        Console.WriteLine("please press A or B");
        R= Console.ReadKey(true).KeyChar;
       
        if (R == 'A' || R == 'a')
            {
            result = result + R.ToString();
            Console.WriteLine(result);
        }

        else if(R=='B' || R == 'b')
           { 
            result = result + R.ToString();
            Console.WriteLine(result);
        }

    }
}
        
