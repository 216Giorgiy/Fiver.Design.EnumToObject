using System;

namespace Fiver.Design.EnumToObject
{
    public static class NationalInsuranceService
    {
        public static bool IsExempt(NationalInsuranceLetters letter)
        {
            if (!Enum.IsDefined(typeof(NationalInsuranceLetters), letter))
                throw new ArgumentException($"invalid letter being passed {letter}");

            return letter == NationalInsuranceLetters.C || letter == NationalInsuranceLetters.X;
        }
    }
}
