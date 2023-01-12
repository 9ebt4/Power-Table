using System;
using System.Data;
using System.Net.Security;
//Welcome
Console.WriteLine("Hello, welcome to the Power Table.");

//loop
bool loop = true;
while (loop)
{
    int num = 0;
    while (true)
    { //Enter Integer
        Console.WriteLine("Please enter an integer to activate the Power Table.");
        num = int.Parse(Console.ReadLine());
        if (num < 1291 && num > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a number between 0 and 1291.");
        }
    }
   
    //value info
    Console.WriteLine(String.Format("{0,15}{1,15}{2,15}" , "Number","Square","Cube"));
     
    //Looop
    for (int num2 = 1; num2 <= num; num2++)
    {
        Console.WriteLine(String.Format("{0,15}{1,15}{2,15}", num2 , squareNumber(num2) , cubeNumber(num2)));
    }
    while (true)
    {//Continue?
        Console.WriteLine("Would you like to continue?");
        string ans = Console.ReadLine().Trim().ToLower();
        if (ans == "y" || ans == "yes" || ans == "yeah" || ans == "yep")
        {
            break;
        }
        else if (ans == "n" || ans == "no" || ans == "nah")
        {
            loop= false;
            break;
        }
        else
        {
            Console.WriteLine("Please use yes or no.");
        }
    }
}
Console.WriteLine("Have a good day.");

//Methods
static int squareNumber(int x)
{
    return x * x;
}

static int cubeNumber(int x)
{
    return x * x * x;
}