using System;

namespace PasswordGen
{
    class Program
    {
        static void Main(string[] args)
        {
            GenPassword();
        }

        static void GenPassword()
        {
            // random numbers
            Random random = new Random();
            int randomNum1 = random.Next(1, 255);
            int randomNum2 = random.Next(1, 255);
            int randomNum3 = random.Next(1, 255);
            int randomNum4 = random.Next(1, 255);
            int randomNum5 = random.Next(1, 255);
            int randomNum6 = random.Next(1, 255);
            int randomNum7 = random.Next(1, 255);
            int randomNum8 = random.Next(1, 255);
            int randomNum9 = random.Next(1, 255);
            int randomNum10 = random.Next(1, 255);

            //make empty strings
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            char letter;

            //random values to convert to characters for letters
            int randValue = random.Next(0, 26);
            letter = Convert.ToChar(randValue + 65);
            str1 = str1 + letter;
            randValue = random.Next(0, 26);
            char letter2 = Convert.ToChar(randValue + 65);
            str2 = str2 + letter2;
            randValue = random.Next(0, 26);
            char letter3 = Convert.ToChar(randValue + 65);
            str3 = str3 + letter3;
            randValue = random.Next(0, 26);
            char letter4 = Convert.ToChar(randValue + 65);
            str4 = str4 + letter4;
            randValue = random.Next(0, 26);
            char letter5 = Convert.ToChar(randValue + 65);
            str5 = str5 + letter5;

            // write the random numbers
            Console.WriteLine("Your password is " + randomNum1 + "" + str1 + "" + randomNum2 + "" + str2 + "" + randomNum3 + "" + str3 + "" + randomNum4 + "" + str4 + "" + randomNum5 + "" + str5 + "" + randomNum6 + "" + randomNum7 + "" + randomNum8 + "" + randomNum9 + "" + randomNum10);
            Console.WriteLine();

            //read key and call method again for inf loop
            Console.ReadLine();
            GenPassword();
        }
    }
}
