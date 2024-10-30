/* توضیحات 
 tamrin 5 */
char r ='a';

string result = "";
Console.WriteLine("please enter smt and if you press esc the consol will be close");
do
{//if charecter is'nt a number 
    // in (if)  adad dakhel result ro reset mikone age nakhim reset she ono comment mikonim
    if (result != "")
    {
        Console.WriteLine("the result is :");
        Console.WriteLine(result);
        result = "";
    }
    int x = r;
    if(x == 27 )
    {
        Console.WriteLine("khodahafez ei yar ghadimi,............ ");
        break;
    }
    r = Console.ReadKey(true).KeyChar;
    
   
    //if charecter is a number  write it in result string

    while (r =='0'|| r == '1' || r == '2' || r == '3' || r == '4' || r == '5' || r == '6' || r == '7' || r == '8' || r == '9' )
    {
       
        result = result + r;
        r = Console.ReadKey(true).KeyChar;
        
    }

} while (r != '0' || r != '1' || r != '2' || r != '3' || r != '4' || r != '5' || r != '6' || r != '7' || r != '8' || r != '9');
