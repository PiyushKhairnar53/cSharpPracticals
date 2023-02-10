using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class UserDetails
    {
        public string? fName, lName, email, contNo, dOB, gender, spouseName, marStatus;
        public bool haveSpouse, haveChilds;
        public int? noOfChilds,userId=0;
        public List<String>? childNames;

        public UserDetails()
        {

            Random rnd = new();
            userId = rnd.Next(10000,999999);    

        }

        public void GetDetails() {

            do
            {
                Console.WriteLine("First name - ");
                fName = Console.ReadLine();
            } while (fName!.Length == 0);

            do
            {
                Console.WriteLine("Last name - ");
                lName = Console.ReadLine();
            } while (lName!.Length == 0);

            GetEmail();
            GetContact();

            Console.WriteLine("Enter your Date of Birth (DD/MM/YYYY) : ");
            dOB = Console.ReadLine();

            GetGender();
            GetMaritualStatus();


        }

        public void GetEmail() {

            string valid ;
            do
            {
                Console.WriteLine("Please enter a valid Email id - ");
                email = Console.ReadLine();
                bool isEmail = Regex.IsMatch(email!, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                valid = isEmail ? "true" : "false";

            } while (valid == "false");

        }

        public void GetContact() {

            string valid ;
            do
            {

                Console.WriteLine("Please enter a valid Contact No : ");
                contNo = Console.ReadLine();

                bool isContNo = Regex.IsMatch(contNo!, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", RegexOptions.IgnoreCase);
                valid = isContNo ? "true" : "false";

            } while (valid == "false");

        }

        public void GetGender() {

            Console.WriteLine("Enter gender (M/m or F/f): ");
            char? g = Convert.ToChar(Console.ReadLine()!);
            if (g == 'm' || g == 'M')
            {

                gender = "male";

            }

            if (g == 'f' || g == 'F')
            {
                gender = "female";
            }

        }

        public void GetMaritualStatus() {

            Console.WriteLine("Are you married (y/Y or n/N) : ");
            string? m = Console.ReadLine();

            if (m == "y" || m == "Y" || m == "Yes" || m == "yes")
            {

                marStatus = "married";
                haveSpouse = true;

                Console.WriteLine("Please enter your spouse name - ");
                spouseName = Console.ReadLine();

                Console.WriteLine("Do you have childrens (y/Y or n/N) : ");
                string? c = Console.ReadLine();


                if (c == "y" || c == "Y" || c == "Yes" || c == "yes")
                {
                    haveChilds = true;
                    Console.WriteLine("Total no of childrens you have : ");
                    noOfChilds = Convert.ToInt32(Console.ReadLine());

                    childNames = new List<string>((int)noOfChilds);

                    for (int? i = 0; i < noOfChilds; i++)
                    {

                        Console.WriteLine($"Enter Name of Child {i+1} : ");
                        childNames.Add(Console.ReadLine()!);
                    
                    }

                }


            }

            if (m == "n" || m == "N" || m == "No" || m == "no")
            {
                marStatus = "unmarried";
                haveSpouse = false;
            }

        }


    }
}
