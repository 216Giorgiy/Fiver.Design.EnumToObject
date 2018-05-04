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
            //CalculateNationalInsurance_Enum((NationalInsuranceLetters)20); // works! despite 20 not being a valid value

            // Using Objects
            //CalculateNationalInsurance_Object(NationalInsuranceLetter.X); // works
            //var letter = new NationalInsuranceLetter(); // can't even create an invalid object, better design to avoid extra code and bugs

            Console.ReadLine();
        }

        static void CalculateNationalInsurance_Enum(NationalInsuranceLetters letter)
        {
            // have to add error checks to ensure valid enum is being passed e.g.
            //if (!Enum.IsDefined(typeof(NationalInsuranceLetters), letter))
            //    throw new ArgumentException($"invalid letter being passed {letter}");

            if (letter == NationalInsuranceLetters.C || letter == NationalInsuranceLetters.X) // poor encapsulation, code duplication
                Console.WriteLine($"don't calculate national insurance for {letter}");
            else
                Console.WriteLine($"calculate national insurance for {letter}");
        }

        static void CalculateNationalInsurance_Object(NationalInsuranceLetter letter)
        {
            if (letter.IsExempt()) // good encapsulation, reuse
                Console.WriteLine($"don't calculate national insurance for {letter}");
            else
                Console.WriteLine($"calculate national insurance for {letter}");
        }
    }
}
