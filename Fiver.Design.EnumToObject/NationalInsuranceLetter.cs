using System;

namespace Fiver.Design.EnumToObject
{
    // rules: https://www.gov.uk/national-insurance-rates-letters/category-letters

    public sealed class NationalInsuranceLetter
    {
        private readonly NationalInsuranceLetters letter;

        private NationalInsuranceLetter(NationalInsuranceLetters letter)
        {
            this.letter = letter;
        }

        public static NationalInsuranceLetter A = 
            new NationalInsuranceLetter(NationalInsuranceLetters.A);

        public static NationalInsuranceLetter B = 
            new NationalInsuranceLetter(NationalInsuranceLetters.B);

        public static NationalInsuranceLetter C = 
            new NationalInsuranceLetter(NationalInsuranceLetters.C);

        public static NationalInsuranceLetter H = 
            new NationalInsuranceLetter(NationalInsuranceLetters.H);

        public static NationalInsuranceLetter J = 
            new NationalInsuranceLetter(NationalInsuranceLetters.J);

        public static NationalInsuranceLetter M = 
            new NationalInsuranceLetter(NationalInsuranceLetters.M);

        public static NationalInsuranceLetter X = 
            new NationalInsuranceLetter(NationalInsuranceLetters.X);

        public static NationalInsuranceLetter Z = 
            new NationalInsuranceLetter(NationalInsuranceLetters.Z);

        public bool IsExempt() =>
            this.letter == NationalInsuranceLetters.C || this.letter == NationalInsuranceLetters.X;

        public bool CanDefer() =>
             this.letter == NationalInsuranceLetters.J || this.letter == NationalInsuranceLetters.Z;

        public bool ForUnder21() =>
             this.letter == NationalInsuranceLetters.M || this.letter == NationalInsuranceLetters.Z;

        public bool ForApprenticeUnder25() =>
            this.letter == NationalInsuranceLetters.H;

        public override string ToString() => this.letter.ToString();
    }
}