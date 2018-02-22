using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreenvilleRevenue
    {
        static void Main(string[] args)
        {
        int FEE = 25;
        int contestantsThisYear;
        int contestantsLastYear;
        int expectedRevenue;
        {

        }

        WriteLine("Enter the number of contestants this year between 0-30: ");
        contestantsThisYear = Convert.ToInt32(ReadLine());

        while(contestantsThisYear < 0 || contestantsThisYear > 30)
        {
            WriteLine("That number is invalid. Please enter a number between 0-30: ");
            contestantsThisYear = Convert.ToInt32(ReadLine());
        }

        WriteLine("Enter the number of contestants from last year between 0-30: ");
        contestantsLastYear = Convert.ToInt32(ReadLine());

        while (contestantsLastYear < 0 || contestantsLastYear > 30)
        {
            WriteLine("That number is invalid. Please enter a number between 0-30: ");
            contestantsLastYear = Convert.ToInt32(ReadLine());
        }

                expectedRevenue = contestantsThisYear * FEE;

                WriteLine(expectedRevenue.ToString("C"));
                if (contestantsThisYear > (contestantsLastYear * 2))
                {
                    WriteLine("The competition is more than twice as big this year! ");
                }
                else if ((contestantsThisYear <= (contestantsLastYear * 2)) && (contestantsThisYear > contestantsLastYear))
                {
                    WriteLine("The competition is bigger than ever!");
                }
                else
                    WriteLine("A tighter race this year! Come out and cast your vote!");
        }
 }

