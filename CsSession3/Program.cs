using System;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

namespace CsSession3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert 
            /*Console.WriteLine("Enter Your Data");

            Console.Write("Enter Your Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Salary: ");
            Decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            Console.WriteLine("Your Name is : " + Name);
            Console.WriteLine("Your Salary is : " + Salary);
            Console.WriteLine("Your Age is : " + Age);*/

            #endregion

            #region Q1

            /*Console.Write("Enter a Number: ");
            int num; int.TryParse(Console.ReadLine(), out num);
            Console.Clear(); Console.WriteLine("Your Number is: " + num);*/

            #endregion

            #region Q2

            //string s = "abc";

            /*int n = Convert.ToInt32(s);
            Console.WriteLine(n); // Throw an Exeption because format*/

            /*int nn = int.Parse(s);
            Console.WriteLine(nn); // Throw an Exeption because format*/

            /*int nnn; int.TryParse(s, out nnn);
            Console.WriteLine(nnn); // Handle input and print 0*/

            #endregion

            #region Q3

            /*double num = 10.2;
            double num2 = 10.8;
            Console.WriteLine("The Resault of Sum: " + (num+num2));*/
            // Runs Correctly and print 21

            #endregion

            #region Q4

            /*string s = "Mootaaz";
            string ss = s.Substring(0,4); Console.WriteLine(ss);*/


            #endregion

            #region Q5

            /*int n = 10;
            int nn = n;

            Console.WriteLine(n);   //Print 10
            Console.WriteLine(nn);  //Print 10

            nn = 20;

            Console.WriteLine(n);   //Print 10
            Console.WriteLine(nn);  //Print 20

            // nn only changed because value type depnds on value on stack not address on heap*/


            #endregion

            #region Q6

            /*Person p = new Person();
            p.Name = "Mootaaz";

            Person pp = p; 
           
            pp.Name = "Mohamed"; 
            Console.WriteLine("First Preson Name = " + p.Name);
            Console.WriteLine("Second Person Name = " + pp.Name);

            //After assigment (pp = p), the pp shows what is in the address of p
            //So, When we change pp with mohamed, p was affected too because they share same address*/

            #endregion

            #region Q7

            /*string s = "Mootaaz";
            string ss = "Mohamed";

            string Name = s + " " + ss;
            Console.WriteLine("Full Name: " + Name);*/

            #endregion

            #region Q8

            /*decimal prin, rate, time;

            Console.Write("Enter the Principle: ");
            decimal.TryParse(Console.ReadLine(), out prin);

            Console.Write("Enter the Rate: ");
            decimal.TryParse(Console.ReadLine(), out rate);

            Console.Write("Enter the Time: ");
            decimal.TryParse(Console.ReadLine(), out time);

            decimal interest = (prin * rate * time) / 100;
            Console.Clear(); Console.WriteLine("Interest Value: " + interest);*/

            #endregion

            #region Q9

            /*double w = 120;
            double h = 1.92;
            double BMI = (w / (h*h));
            Console.WriteLine("The BMI is :" + BMI);*/

            #endregion

            #region Q10

            /*int temp;
            int.TryParse(Console.ReadLine(), out temp);

            string s = (temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good");
            Console.WriteLine(s);*/

            #endregion

            #region Q11

            /*int d, m, y;

            Console.Write("Enter the Day: ");
            int.TryParse(Console.ReadLine(), out d);

            Console.Write("Enter the Month: ");
            int.TryParse(Console.ReadLine(), out m);

            Console.Write("Enter the Year: ");
            int.TryParse(Console.ReadLine(), out y);

            Console.Clear();
            Console.WriteLine($"Today's Date : {d} , {m} , {y}");
            Console.WriteLine($"Today's Date : {d} / {m} / {y}");
            Console.WriteLine($"Today's Date : {d} - {m} - {y}");*/


            #endregion

            #region Q12

            /*int n; int.TryParse(Console.ReadLine(), out n);

            if(n%3==0 &&  n%4==0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");*/

            #endregion

            #region Q13

            /*int n; int.TryParse(Console.ReadLine(), out n);

            if (n > 0)
                Console.WriteLine("Postive");
            else if (n < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");

            // I Consider Zero as a Diffrent Case*/

            #endregion

            #region Q14


            /*int n, nn, nnn;

            Console.Write("Enter the First Number: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.Write("Enter the Second Number: ");
            int.TryParse(Console.ReadLine(), out nn);

            Console.Write("Enter the Third Number: ");
            int.TryParse(Console.ReadLine(), out nnn);

            int max = n;
            int min = n;*/

            //First Way

            /*if (nn > max)
                max = nn;
            if (nnn > max)
                max = nnn;

            if (nn < min)
                min = nn;
            if (nnn < min)
                min = nnn;

            Console.WriteLine("The Maximum Num is: " + max);
            Console.WriteLine("The Minimum Num is: " + min);*/


            // Second Way

            /*max = Math.Max(max, Math.Max(nn,nnn));
            min = Math.Min(min, Math.Min(nn,nnn));

            Console.WriteLine("The Maximum Num is: " + max);
            Console.WriteLine("The Minimum Num is: " + min);*/


            #endregion

            #region Q15

            /*int n; int.TryParse(Console.ReadLine(), out n);

            if(n%2==0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");

            //Here consider 0 as an even number*/

            #endregion

            #region Q16

            /*Console.Write("Enter a Char: ");
            char c; char.TryParse(Console.ReadLine().ToLower(), out c);

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");*/

            // I used ToLower to Handle if use input vowel char in capital

            #endregion

            #region Q17

            /*Console.Write("Enter Month: ");
            int m; int.TryParse(Console.ReadLine(), out m);

            if (m == 1 || m == 3 || m == 5 || m == 7 ||
            m == 8 || m == 10 || m == 12)
                Console.WriteLine("Days in Month is: 31");
            else if (m == 4 || m == 6 || m == 9 || m == 11)
                Console.WriteLine("Days in Month is: 30");
            else if (m == 2)
                Console.WriteLine("Days in Month is: 28");
            else
                Console.WriteLine("Enter Valid Month Number");*/

            #endregion

        }

        class Person
        {
            public string Name;
        }



    }
}
