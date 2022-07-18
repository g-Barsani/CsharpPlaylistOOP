using System;

namespace _13Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            NaturalPerson np = new NaturalPerson();
            np.taxLoan(1000);

            LegalPerson lp = new LegalPerson();
            lp.taxLoan(1000);
        }
    }
}