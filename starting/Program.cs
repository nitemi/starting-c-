// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        //writing to console
        Console.WriteLine("Welcome to class, please enter your firstname");
        /*there are to ways to read and write to console
         Concartenanation*/

        string FirstName = Console.ReadLine();

        Console.WriteLine("Welcome to class, please enter your lastname");
           
            string LastName = Console.ReadLine();
        Console.WriteLine("It is good to have you " + FirstName + " " + LastName);
        //place holder syntax and also note that c# is case sensitive
        //Console.WriteLine("It is good to have you {0},{1}", FirstName, LastName);
    }
    /*built in types
     boolean type
    integral= bytes,sbyte(-),char,short(-),ushort(+),int(+,-),uint(+),long(+,-),ulong(+)
    floating = float and double
    decimal
    string
    */

    bool b =false;

}