string[,] answer = { { "\n\teat fast food", " \n\teat helthy food", "\n\t eat evry thing you can" }, { "\n \tdo tennis", "\n \tplay ea sports", "\n\t do body bulding" }, { "\n\t 6 glass ", "\n\t7 glasss", "\n\t idk" } };
string[] question = { "\nwhat are you eat in day ?", "\nwhat sport you do", "\nhow much water do  you drink" };
int helthnum = 10;

for (int i = 0; i < 3; i++)
{
    char a = 'r';
    Console.WriteLine($"\nplease enter \n\ta for: {answer[i, 0]}\n\tb for: {answer[i, 1]}\n\tc for: {answer[i, 2]}");
    Console.WriteLine(question[i]);
    a = Console.ReadKey().KeyChar;
    switch (a)
    {
        case 'a':
            helthnum++;

            break;
        case 'b':
            helthnum--;
            break;
        case 'c':
            helthnum = helthnum;
            break;

    }

}
Console.WriteLine($"\nYour helth number is: {helthnum}\n ");
HelthCheck(helthnum); // in ham optinal hast va mishe estefade nakard
void HelthCheck(int helthnum)
{
   
    switch (helthnum)
    {

        case int x when x > 10:
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\nyou are helthy");
            Console.BackgroundColor = ConsoleColor.Black;

            break;
        case int x when x == 10:
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nyou are normal");
            Console.BackgroundColor = ConsoleColor.Black;

            break;
        case int x when x < 10:
            Console.BackgroundColor = ConsoleColor.Red;   
            Console.WriteLine("\nyou are not helthy");
            Console.BackgroundColor = ConsoleColor.Black;

            break;
    }
}