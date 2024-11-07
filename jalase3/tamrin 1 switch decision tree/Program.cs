//tamrin jalase 3 decision tree with switch amirhossein naseh      #type 1
string result = null;
string[,] qus = { { "cafe", "tea", "soda" }, { "10%-water", "20%-water", "30%-water" }, { "sweet", "normal", "dietary" } };
int[,] PriceArrr = {    {20000,4000,12000},{2000,1000,500},{4000,0,1000}};
char input = 'a';

int  price=0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine();
    Console.WriteLine($"please evry time choose one item with press key 1 for {qus[i,0]} and press key 2 for {qus[i, 1]}and press key 3 for {qus[i, 2]}");
    while (true)
    {
        char c = 'l';
            int a = 0;
        c = Console.ReadKey().KeyChar;
        a = c - '0';
        if (a <= 3)
        {
            input = c;
            break;

        }
        else
            Console.WriteLine("please enter right number");
    }
   
    switch (input)
    {
        case '1':
            result += qus[i, 0] + " ";
            price += PriceArrr[i,0];
        
            break;
        case '2':
            result += qus[i, 1] + " ";
            price += PriceArrr[i,1];
           
            break;
        case '3':
            result += qus[i, 2] + " ";
            price += PriceArrr[i,2];
           
            break;

        default:
            break;
    }
    
}//در اصل تکلیف تا این قسمته و تابع cost جدا برای قیمت ه

//price=cost(result);
Console.WriteLine("you have a :"+result + "and that cost "+ price);
Console.WriteLine();
//Console.WriteLine($" and that cost {price}");
int cost (string res)
{ int cost = 0 , n=0,z=0;
    string[] x =new string [4];
    z = res.Length;
  
    for (int i = 0;i<res.Length;i++)
    {
        if (res[i] == ' ')
            n++;
        else
            x[n] += res[i];
    }
    switch(x[0])
    {
        case "cafe":
            cost += 10000;
            break;
        case "tea":
            cost += 5000;
            break;
        case "soda ":
            cost += 25000;
            break;
    }
    switch (x[2])
    {
        case "sweet":
            cost = cost+ 200;
            break;
        case "normal":
            cost = cost + 500;
            break;
        case "dietary ":
            cost = cost + 2500;
            break;
    }
    Console.WriteLine(x[2]);
    return cost;
}//