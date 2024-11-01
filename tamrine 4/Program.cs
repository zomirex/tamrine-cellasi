





/* توضیحات 
 tamrin 4 */
char R;
int r;
string result="";
Console.WriteLine("please enter smt and if you press esc the consol will be close");
do
{//if charecter is'nt a letter 
    // in if  horoof dakhel result ro reset mikone age nakhim reset she ono comment mikonim
    if (result != ""){ 
        Console.WriteLine(result);
        result = "";
    }
    R = Console.ReadKey(true).KeyChar;
     r = R ;
    if (r == 27)
    {
        Console.WriteLine("ma raftim by by maraftim");
        break;
    }
    //if charecter is a letter  write it in result string

    while ((r>=65 && r<=90) || (r >= 97 && r <= 122))
    {
        result = result + R ;
        R = Console.ReadKey().KeyChar;
        r = R;
    }
    
    
    
} while ((r <= 65 )|| (r >= 122)||(r >= 90 && r <= 97));