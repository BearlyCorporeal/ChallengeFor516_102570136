using System;
using ShapeClassLibrary;
namespace ShapeCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int loopE = 0;
            int tryloop1 = 0 ;
            int input2 = 0;
            string colour = "";
            int SideLength1 = 0;
            int SideLength2 = 0;
            Console.WriteLine("what colour would you like your shape to be");
            colour = Console.ReadLine();
            Console.WriteLine("what type of shape would you like to create");
            Console.WriteLine("1 to create a Square");
            Console.WriteLine("2 to create a Rectangle");

            while (loopE == 0)
            {
                input = Console.ReadLine();
                if(input == "1")
                {
                    loopE = 1;
                }
                if (input == "2")
                {
                    loopE = 1;
                }
                if (loopE == 0)
                {
                    Console.WriteLine("please use either 1 or 2");
                }

            }
            
            if (input == "1")
            {
                Console.WriteLine("what length would you like the sides to be");
                while(tryloop1 == 0)
                try
                {
                    input2 = int.Parse(Console.ReadLine());
                    if (input2 < 1)
                    {
                        throw new lessthan1Exeption("this number is less than 1");
                    }
                    SideLength1 = input2;
                        tryloop1 = 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("you need to input a number");
                        tryloop1 = 0;
                }
                catch(lessthan1Exeption)
                {
                        Console.WriteLine("the number needs to be at least 1");
                        tryloop1 = 0;
                }
                    
                tryloop1 = 0;
                new Square(colour, SideLength1);
                Console.WriteLine("you made a shape well done!");
            }
            if (input == "2")
            {
                Console.WriteLine("what length would you like the first set of sides to be");
                while (tryloop1 == 0)
                    try
                    {
                        input2 = int.Parse(Console.ReadLine());
                        if (input2 < 1)
                        {
                            throw new lessthan1Exeption("this number is less than 1");
                        }
                        SideLength1 = input2;
                        tryloop1 = 1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("you need to input a number");
                        tryloop1 = 0;
                    }
                    catch (lessthan1Exeption)
                    {
                        Console.WriteLine("the number needs to be at least 1");
                        tryloop1 = 0;
                    }
                tryloop1 = 0;
                Console.WriteLine("what length would you like the second set of sides to be");
                while (tryloop1 == 0)
                    try
                    {
                        input2 = int.Parse(Console.ReadLine());
                        if (input2 < 1)
                        {
                            throw new lessthan1Exeption("this number is less than 1");
                        }
                        SideLength2 = input2;
                        tryloop1 = 1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("you need to input a number");
                        tryloop1 = 0;
                    }
                    catch (lessthan1Exeption)
                    {
                        Console.WriteLine("the number needs to be at least 1");
                        tryloop1 = 0;
                    }
                tryloop1 = 0;
                new Rectangle(colour, SideLength1, SideLength2);
                Console.WriteLine("you made a shape well done!");
            }
        }
        class lessthan1Exeption : Exception
        {
            public lessthan1Exeption(string message) : base(message)
            {
            }
        }
    }
}
