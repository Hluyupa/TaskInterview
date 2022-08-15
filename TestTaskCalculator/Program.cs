using System;

public class Program 
{ 
     
    public static void Main(string[] args) 
    {
        Start();
        End();
    }

    private static void Start() 
    {
        string operation;
        double op1 = 0, op2 = 0;
        bool correctValue = true;
        Console.Clear();
        Console.WriteLine("Enter first operator");
        CheckValidOperator(ref op1);
        Console.WriteLine("Enter second operator");
        CheckValidOperator(ref op2);
        do
        {
            Console.WriteLine("Enter your operation:\n + | - | * | /");
            operation = Console.ReadLine();
            switch (operation)
            {
                case @"+":
                    Console.WriteLine(Sum(op1, op2));
                    correctValue = true;
                    break;
                case @"-":
                    Console.WriteLine(Subtract(op1, op2));
                    correctValue = true;
                    break;
                case @"*":
                    Console.WriteLine(Multiply(op1, op2));
                    correctValue = true;
                    break;
                case @"/":
                    Console.WriteLine(Divide(op1, op2));
                    correctValue = true;
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    correctValue = false;
                    break;
            }
        }while(!correctValue);
    }

    private static void End() 
    {
        char userResponce;
        bool correctValue = true;
        do
        {
            Console.WriteLine("Do you want to continue(y/n)?");
            userResponce = Convert.ToChar(Console.ReadLine().ToLower());
            if (userResponce == 'y')
            {
                Start();
                correctValue = false;
            }
            else if (userResponce == 'n')
            {
                Console.ReadLine();
                correctValue = true;
            }
            else
            {
                Console.WriteLine("Please enter valid choice");
                correctValue = false;
            }
        } while (!correctValue);
    }

    static void CheckValidOperator(ref double op)
    {
        bool correctOperator;
        do
        {
            correctOperator = double.TryParse(Console.ReadLine(), out op);
            if (!correctOperator)
            {
                Console.WriteLine("Please enter a valid choice");
            }
        } while (!correctOperator);
    }

    static double Divide(double op1, double op2) 
    { 
        return op1 / op2; 
    } 

    static double Multiply(double op1, double op2)
    { 
        return op1 * op2;
    } 

    static double Subtract(double op1, double op2)
    {
        return op1 - op2;
    }

    static double Sum(double op1, double op2) 
    { 
        return op1 + op2; 
    } 

    
} 