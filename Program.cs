using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your \n first number");
        string NumbaTop = Console.ReadLine();
        int Numerator = Convert.ToInt32(NumbaTop);


        Console.WriteLine("Please enter your \n second number");
        string NumbaBottom = Console.ReadLine();
        int Denominator = Convert.ToInt32(NumbaBottom);

        Console.WriteLine("This is the Numerator: {0} ", Numerator);
        Console.WriteLine("This is the Denominator: {0} ", Denominator);

        int Result = Numerator / Denominator;
        int Remainder = Numerator % Denominator;

        Console.WriteLine("This is the division Result: {0} ", Result);

        Console.WriteLine("This is the division Remainder: {0} ", Remainder);

        if (Numerator == 34)
        {
            Console.WriteLine("It matches 34!");
        }
        else
        {
            Console.WriteLine("It does not match 34.");
        }

        //bool IsNumber10;

        //if (Numerator == 10)
        //{
        //    IsNumber10 = true;
        //}
        //else
        //{
        //    IsNumber10 = false;
        //}

        bool IsNumber10 = Numerator == 10 ? true : false;

        Console.WriteLine("Does the numerator equal 10?:  {0}", IsNumber10);

    }
    static void Main1()
    {
        Console.WriteLine("Please enter your \n first name");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your \n last name");
        string LastName = Console.ReadLine();

        Console.WriteLine("Hello {0} {1}", FirstName, LastName);

        Console.WriteLine(@"Verbatim Literals: I'm glad to know how to show all \\ characters by using the at sign.");



        //Console.WriteLine("Hello " + UserName);
    }
}