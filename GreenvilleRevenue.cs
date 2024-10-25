using System;

class GreenvilleRevenue
{
    static void Main(string[] args)
    {

        //Display Interface
        ShowMottoAndMenu();

        while (true)
        {
            Console.WriteLine("Please enter the following number below from the following menu");
            Console.WriteLine("1) Calculate Greenville Reveniue Year-Over-Year");
            Console.WriteLine("2) Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CalculateRevenue();
                ShowMottoAndMenu();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you for using the Greenville Revenue app, Good-Bye.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid entry please select 1 or 2.");
            }
        }
    }
    static void ShowMottoAndMenu()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
    }
    static void CalculateRevenue()
    {
        Console.WriteLine("Please enter the number of contestants from last year:");
        int lastYearContestants = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of contestants for this year:");
        int thisYearContestants = int.Parse(Console.ReadLine());

        //Revenue formula

        int revenue = thisYearContestants * 25;

        //Output revenue

        Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year has {thisYearContestants} contestants.");
        Console.WriteLine($"Revenue expected this year is ${revenue}");

        //Compare years

        if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("It is true that this year's competition is bigger than last year's.");
        }
        else
        {
            Console.WriteLine(" It is false that this year's competition is bigger than last year's.");
        }
    }
}
