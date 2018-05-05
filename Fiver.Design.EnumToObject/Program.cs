using System;

namespace Fiver.Design.EnumToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Enums
            //CalculateNationalInsurance_Enum(NationalInsuranceLetters.X); // works
            //CalculateNationalInsurance_Enum(NationalInsuranceLetters.A); // works
            //CalculateNationalInsurance_Enum((NationalInsuranceLetters)20); // accepts input! 

            // Using Objects
            //var letter = new NationalInsuranceLetter(); // can't even create an invalid object
            CalculateNationalInsurance_Object(NationalInsuranceLetter.X); // works

            Console.ReadLine();
        }

        static void CalculateNationalInsurance_Enum(NationalInsuranceLetters letter)
        {
            if (!Enum.IsDefined(typeof(NationalInsuranceLetters), letter))
                throw new ArgumentException($"invalid letter being passed {letter}");

            if (letter == NationalInsuranceLetters.C || letter == NationalInsuranceLetters.X) 
                Console.WriteLine($"don't calculate national insurance for {letter}");
            else
                Console.WriteLine($"calculate national insurance for {letter}");
        }

        static void CalculateNationalInsurance_Lib(NationalInsuranceLetters letter)
        {
            if (NationalInsuranceService.IsExempt(letter)) 
                Console.WriteLine($"don't calculate national insurance for {letter}");
            else
                Console.WriteLine($"calculate national insurance for {letter}");
        }

        static void CalculateNationalInsurance_Object(NationalInsuranceLetter letter)
        {
            if (letter.IsExempt())
                Console.WriteLine($"don't calculate national insurance for {letter}");
            else
                Console.WriteLine($"calculate national insurance for {letter}");
        }
    }
}
