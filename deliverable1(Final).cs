using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* num1 is a input variable of first number declared as int datatype
		num2 is a input variable of second number declared as int datatype*/
            int num1, num2 = 0;


            /*chkdigits1 is a variable which assigned for sum1 after converting  data type into int data type 
            chkdigits2 is a variable which assigned for sum2 after converting  data type into int data type */
            int chkdigit1, chkdigit2 = 0;


            /* x1 is a variable assigned for num1 if number of digits in two numbers are equal
            y1 is a variable assigned for num2 if number of digits in two numbers are equal*/
            int x1, y1 = 0;


            /* totaldigits1 is a variable assigned for the total number of digits in first number
            totaldigits2 is a variable assigned for the total number of digits in second number*/
            int totaldigits1 = 0;
            int totaldigits2 = 0;





            /* sum1 is a variable assigned value for sum of first digit,second digit and third digit from both the user input numbers and declared as int datatype */
            int sum1 = 0;
            int presum = 0;
            int checkflag = 0;


            /* Getting first number as a input from user to num1 and convert string value into int value and assign that value to chkdigit1 */
            Console.WriteLine("Enter the first number :");
            num1 = Convert.ToInt16(Console.ReadLine());

            chkdigit1 = num1;

            /* Getting second number as a input from user to num2 and convert string value into int value and assign that value to chkdigit2 */
            Console.WriteLine("Enter the second number :");
            num2 = Convert.ToInt16(Console.ReadLine());

            chkdigit2 = num2;

            /* Finding total number of digits in first number by using while loop and print total number of digits in first number*/
            while (chkdigit1 > 0)
            {
                chkdigit1 = chkdigit1 / 10;
                totaldigits1++;
            }

            Console.WriteLine("total number of digits in first number :" + totaldigits1);


            /*Finding total number of digits in second number by using while loop and print total number of digits in first number*/
            while (chkdigit2 > 0)
            {
                chkdigit2 = chkdigit2 / 10;

                totaldigits2++;
            }

            Console.WriteLine("total number of digits in second number :" + totaldigits2);


            /* Checking either total number of digits in first number is equal to the total number of digits in second number.
            If its equal then it will print number of digits in two numbers are equal or it will print number of digits in in two numbers are not equal  */
            if (totaldigits1 == totaldigits2)

            {
                Console.WriteLine("Number of digits in two numbers are equal");



                /*With the help of forloop printing first,second,third ... digits from both the numbers using formula (x1% 10^(n-i))/ 10^(n-(i+1)),
                               in this formula first we need to find modulus of the given integer with 10^(n-i) where n is the number of digits in the integer

                 and i value is 0 intially then divided by 10^(n-(i+1) for each digit and sum to the same total and checking sums are equal or not equal */

                for (Int32 i = 0; i < totaldigits1; i++)
                {

                    x1 = num1;

                    x1 = (x1 % (Convert.ToInt32(Math.Pow(10, (totaldigits1 - i))))) / (Convert.ToInt32(Math.Pow(10, (totaldigits1 - (i + 1)))));

                    Console.WriteLine("First digit from num1 is :" + x1);




                    y1 = num2;

                    y1 = (y1 % (Convert.ToInt32(Math.Pow(10, (totaldigits2 - i))))) / (Convert.ToInt32(Math.Pow(10, (totaldigits2 - (i + 1)))));

                    Console.WriteLine("First digit from num1 is :" + y1);


                    sum1 = (x1 + y1);

                    Console.WriteLine("total:" + sum1);

                    /* Assigning sum1 value to the presum If sum of the corresponding digits are equal then output will be true or output will be false */

                    if (presum != sum1)
                    {
                        checkflag++;

                    }
                    presum = sum1;
                }

                /* If checkflag shows greater than 1 then sum of the digits are not equal else output will be true*/

                if (checkflag > 1)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }

            }

            else
            {

                Console.WriteLine("Number of digits in two numbers are not equal");

            }

            Console.ReadLine();


        }
    }
}
    

