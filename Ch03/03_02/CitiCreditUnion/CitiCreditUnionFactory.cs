using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiCreditUnion
{
    // Concrete ProductA1
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Console.WriteLine("Returned Citi Savings Account");
        }
    }


    // Concrete ProductB1
    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("Returned Citi Loan Account");
        }
    }


    // Concrete Factory 1
        public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            CitiLoanAccount obj = new CitiLoanAccount();
            return obj;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            CitiSavingsAccount obj = new CitiSavingsAccount();
            return obj;
        }
    }

}
