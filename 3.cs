
using System;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Prime Number Calculator");
            Console.WriteLine("2. Palindrome Number Checker");
            Console.WriteLine("3. Decision Tree (Sport Preferences)");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice (1-3, or 0 to exit): ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PrimeNumberCalculator();
                    break;

                case "2":
                    PalindromeNumberChecker();
                    break;

                case "3":
                    DecisionTree();
                    break;

                case "0":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }

  
    static void PrimeNumberCalculator()
    {
        Console.Clear();
        Console.WriteLine("Prime Number Calculator");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1000)
        {
            
            PrimeNumbersMethod1(number);
        }
        else
        {
      
            PrimeNumbersMethod2(number);
        }

        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }


    static void PrimeNumbersMethod1(int n)
    {
        var timer = new Stopwatch();
        timer.Start();

        bool check;
        for (int i = n + 1; i < 1000; i++)
        {
            check = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    check = false;
                    break;
                }
            }

            if (check)
                Console.Write("{0} ", i);
        }

        timer.Stop();
        Console.WriteLine();
        Console.WriteLine("Execution time is: " + timer.ElapsedMilliseconds + "ms");
    }

    static void PrimeNumbersMethod2(int n)
    {
        var timer = new Stopwatch();
        timer.Start();

        bool check;
        int condition;
        for (int i = n + 1; i < 10000; i++)
        {
            check = true;
            condition = Convert.ToInt32(Math.Sqrt(i));
            for (int j = 2; j <= condition; j++)
            {
                if (i % j == 0)
                {
                    check = false;
                    break;
                }
            }

            if (check)
                Console.Write("{0} ", i);
        }

        timer.Stop();
        Console.WriteLine();
        Console.WriteLine("Execution time is: " + timer.ElapsedMilliseconds + "ms");
    }


    static void PalindromeNumberChecker()
    {
        Console.Clear();
        Console.WriteLine("Palindrome Number Checker");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

    
        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} is a palindrome!");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a palindrome.");
        }

        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }

 
    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = (reversedNumber * 10) + digit;
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }


    static void DecisionTree()
    {
        Console.Clear();
        Console.WriteLine("Decision Tree - What's your favorite sport?");
        Console.WriteLine("1. Football");
        Console.WriteLine("2. Basketball");
        Console.WriteLine("3. Tennis");
        Console.WriteLine("4. Other");
        Console.Write("Enter your choice (1-4): ");
        string sportChoice = Console.ReadLine();

        switch (sportChoice)
        {
            case "1":
                FootballBranch();
                break;

            case "2":
                BasketballBranch();
                break;

            case "3":
                TennisBranch();
                break;

            case "4":
                OtherSportsBranch();
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }


    static void FootballBranch()
    {
        Console.Clear();
        Console.WriteLine("You chose Football! Do you prefer:");
        Console.WriteLine("1. Playing football");
        Console.WriteLine("2. Watching football");
        Console.WriteLine("3. Coaching football");
        Console.Write("Enter your choice (1-3): ");
        string footballChoice = Console.ReadLine();

        switch (footballChoice)
        {
            case "1":
                Console.WriteLine("You love playing football! Great choice.");
                break;

            case "2":
                Console.WriteLine("You enjoy watching football! A true fan.");
                break;

            case "3":
                Console.WriteLine("You enjoy coaching football! A great leadership skill.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

 
    static void BasketballBranch()
    {
        Console.Clear();
        Console.WriteLine("You chose Basketball! Do you prefer:");
        Console.WriteLine("1. Playing basketball");
        Console.WriteLine("2. Watching basketball");
        Console.WriteLine("3. Coaching basketball");
        Console.Write("Enter your choice (1-3): ");
        string basketballChoice = Console.ReadLine();

        switch (basketballChoice)
        {
            case "1":
                Console.WriteLine("You love playing basketball! Keep practicing your shots.");
                break;

            case "2":
                Console.WriteLine("You enjoy watching basketball! A true fan of the game.");
                break;

            case "3":
                Console.WriteLine("You enjoy coaching basketball! Helping others improve their game.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void TennisBranch()
    {
        Console.Clear();
        Console.WriteLine("You chose Tennis! Do you prefer:");
        Console.WriteLine("1. Playing singles");
        Console.WriteLine("2. Playing doubles");
        Console.WriteLine("3. Watching tennis");
        Console.Write("Enter your choice (1-3): ");
        string tennisChoice = Console.ReadLine();

        switch (tennisChoice)
        {
            case "1":
                Console.WriteLine("You enjoy playing singles! Focus on your footwork and strategy.");
                break;

            case "2":
                Console.WriteLine("You enjoy playing doubles! Teamwork is key in doubles tennis.");
                break;

            case "3":
                Console.WriteLine("You enjoy watching tennis! Great players always inspire.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    
    static void OtherSportsBranch()
    {
        Console.Clear();
        Console.WriteLine("You chose Other sports! Which one is it?");
        Console.WriteLine("1. Swimming");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Running");
        Console.WriteLine("4. Martial Arts");
        Console.Write("Enter your choice (1-4): ");
        string otherSportsChoice = Console.ReadLine();

        switch (otherSportsChoice)
        {
            case "1":
                Console.WriteLine("You enjoy swimming! A great full-body workout.");
                break;

            case "2":
                Console.WriteLine("You enjoy cycling! A great way to stay fit and explore the outdoors.");
                break;

            case "3":
                Console.WriteLine("You enjoy running! It's a great way to improve endurance.");
                break;

            case "4":
                Console.WriteLine("You enjoy martial arts! A great way to learn discipline and self-defense.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
