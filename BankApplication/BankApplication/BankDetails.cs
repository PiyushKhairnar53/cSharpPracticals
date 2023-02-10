using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class BankDetails
    {
        public string? prmAddr = "", comAddr = "" ;
        public bool wantCreditCard,isAddrSame;
        public int? income,crdAllowed;
        public string? accNo = "",crdCardNo = "";


        public void GetBankDetails()
        {
            GetAddress();   
            GenerateAccNo();
            GetCreditDetails();
        }

        public void GetCreditDetails() 
        {
            Console.WriteLine("Do you want credit card (y|Y or n|N) ? : ");
            string? cc = Console.ReadLine();

            if (cc == "y" || cc == "Y" || cc=="Yes" || cc == "yes")
            {
                wantCreditCard = true;

                if (wantCreditCard) 
                {
                    Console.WriteLine("Please enter your annual income : ");
                    income = Convert.ToInt32(Console.ReadLine());

                    if (income < 300000) 
                    {
                        Console.WriteLine("Sorry you are not eligible for Credit card");
                    }
                    if (income > 300000 && income <500000)
                    {
                        crdAllowed = 50000;
                        Console.WriteLine("You are allowed to use credit upto : "+crdAllowed);
                    }
                    if (income > 500000 && income <700000)
                    {
                        crdAllowed = 75000;
                        Console.WriteLine("You are allowed to use credit upto : " + crdAllowed);
                    }
                    if (income > 700000)
                    {
                        crdAllowed = 100000;
                        Console.WriteLine("You are allowed to use credit upto : " + crdAllowed);
                    }

                }

                Random rnd = new();
                var builder = new StringBuilder();

                while (builder.Length < 16)
                {
                    builder.Append(rnd.Next(10)).ToString();
                }

                crdCardNo = builder.ToString();


            }
       

        }

        public void GenerateAccNo() 
        {
            Random rnd = new();
            var builder = new StringBuilder();

            while (builder.Length < 14) 
            {
                builder.Append(rnd.Next(10)).ToString();
            }

            accNo = builder.ToString();
        }

        public void GetAddress()
        {
           
            Console.WriteLine("Please enter your Permanant address - ");
            prmAddr = Console.ReadLine();

            Console.WriteLine("Is your permanant address and communication address same(y|Y or n|N) : ");
            string? c = Console.ReadLine();

            if (c == "y" || c == "Y" || c == "Yes" || c == "yes")
            {
                isAddrSame = true;
                comAddr = prmAddr;
            }
            if (c == "n" || c == "N" || c == "No" || c == "no") 
            {
                isAddrSame = true;
                Console.WriteLine("Please enter your Communication address - ");
                comAddr = Console.ReadLine();
            }

        }

    }
}
