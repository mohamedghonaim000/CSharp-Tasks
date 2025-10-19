using System;
using System.Reflection.Metadata;

namespace assigment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem one
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber % 3 == 0 && UserNumber % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
            #region problem 2 
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber <0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else if (UserNumber==0)
            //{
            //    Console.WriteLine("ZERO not positive not negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion
            #region problem 3
            //int UserNumber1 = Convert.ToInt32(Console.ReadLine());
            //int UserNumber2 = Convert.ToInt32(Console.ReadLine());
            //int UserNumber3 = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber1 > UserNumber2 && UserNumber1> UserNumber3)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber1}");
            //}
            //if (UserNumber1 == UserNumber2 && UserNumber1 > UserNumber3)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber1}");
            //}
            //else if (UserNumber2 > UserNumber1 && UserNumber2 > UserNumber3)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber2}");
            //}
            //else if( UserNumber3 > UserNumber2 && UserNumber3 > UserNumber1 )
            //{
            //    Console.WriteLine($"the max number equal {UserNumber3}");
            //}
            //else if (UserNumber3 == UserNumber2 && UserNumber3 > UserNumber1)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber3}");
            //}
            //else if (UserNumber3 == UserNumber1 && UserNumber3 > UserNumber2)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber3}");
            //}
            //else
            //{
            //    Console.WriteLine("the three numbers are equal");
            //}
            #endregion
            #region problem 4
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber%2==0)
            //{
            //    Console.WriteLine("these number is even");
            //}
            //else
            //{
            //    Console.WriteLine("these number is odd");
            //}
            #endregion
            #region problem 5
            //string word = Console.ReadLine();
            //if (word != null)
            //{
            //    char letter = char.ToLower (word[0]);
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        Console.WriteLine("Vowel");
            //    }
            //    else {
            //        Console.WriteLine("Consonant");
            //    }
            //}
            //else { Console.WriteLine("enter a valid word"); }
            #endregion
            #region problem 6
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= UserNumber; i++)
            //{
            //    Console.WriteLine( i);
            //}
            #endregion
            #region problem 7
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(UserNumber * i);
            //}
            #endregion
            #region problem 8
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < UserNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region problem 9
            //int Number1 = Convert.ToInt32(Console.ReadLine());
            //int Number2 = Convert.ToInt32(Console.ReadLine());
            //double result = Math.Pow(Number1 ,  Number2); 

            //    Console.WriteLine(result);


            #endregion
            #region problem 10
            //int Subject01 = Convert.ToInt32(Console.ReadLine());
            //int Subject02 = Convert.ToInt32(Console.ReadLine());
            //int Subject03 = Convert.ToInt32(Console.ReadLine());
            //int Subject04 = Convert.ToInt32(Console.ReadLine());
            //int Subject05 = Convert.ToInt32(Console.ReadLine());

            //float TotalMarks = (float)(Subject01 + Subject02 + Subject03 + Subject04 + Subject05);
            //float AverageMarks = TotalMarks / 5;
            //float Presentage = (TotalMarks / 500f) * 100;
            //Console.WriteLine($"Total marks = {TotalMarks} /n  AverageMarks = {AverageMarks} /n Presentage = {Presentage}");

            #endregion
            #region problem 11
            //int MonthNumber = Convert.ToInt32(Console.ReadLine());
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 29");
            //        break;
            //    case 3:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 4:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 5:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 6:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 7:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 8:
            //        Console.WriteLine("Days in Month: 29");
            //        break;
            //    case 9:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 10:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //        default:
            //        Console.WriteLine("enter a vaild month number");
            //        break;
            //}

            #endregion
            #region problem 12
            //Console.WriteLine("enter two numbers");
            //int Number1 = Convert.ToInt32(Console.ReadLine());
            //int Number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("for pluse press 1 for subtract press 2 for multiply press3 for division press 4");
            // int OperationNumber = Convert.ToInt32(Console.ReadLine());
            //switch (OperationNumber)
            //{
            //    case 1:
            //        Console.WriteLine(Number1+Number2);
            //        break;
            //    case 2:
            //        Console.WriteLine(Number1 - Number2);
            //        break;
            //    case 3:
            //        Console.WriteLine(Number1 * Number2);
            //        break;
            //    case 4:
            //        Console.WriteLine(Number1 / Number2);
            //        break;
            //    default:
            //        Console.WriteLine("press[1-4]");
            //        break;
            //}

            #endregion
            #region problem 13
            //Console.WriteLine("enter the string that you want to reverce");
            //string word = Console.ReadLine();
            //string ReversedString = "";

            //for (int i = word.Length-1; i >= 0; i--)
            //{
            //    ReversedString += word[i];
            //}
            //Console.WriteLine(ReversedString);


            #endregion
            #region problem 14
            //Console.WriteLine("enter the integer that you want to reverce");
            //int IntegerNumber = Convert.ToInt32(Console.ReadLine());
            //string SIntegerNumber = Convert.ToString(IntegerNumber);
            //string Reversedintegr = "";

            //for (int i = SIntegerNumber.Length - 1; i >= 0; i--)
            //{
            //    Reversedintegr += SIntegerNumber[i];
            //}
            //Console.WriteLine(Reversedintegr);
            #endregion
            #region problem 15
            Console.WriteLine("enter the strat number and the end number");
            int StartNumber = Convert.ToInt32(Console.ReadLine());
            int EndNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = StartNumber; i <= EndNumber; i++)
            {
                int PrimeNumber = 0;
                for (int j = 2; j*j < i; j++)
                {
                    if (i%j == 0)
                    {
                        PrimeNumber = i;
                    }
                }
                Console.WriteLine(PrimeNumber);
            }
            {
                
            }


            #endregion



        }
    }
}
