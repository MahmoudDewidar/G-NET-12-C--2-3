using System;

namespace QuestionsSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            //#region Q1

            // double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x); // Output: 9

            ////d is a double with the value 9.99.
            //// When i write (int)d, you are performing explicit casting from double to int and print 9 

            //#endregion
            //*********************************************************************
            //     #region Q2

            //     int n = 5;
            // double d2 = (double)n / 2;
            //Console.WriteLine(d2); // Output: 2.5

            //     #endregion

            //*********************************************************************
            //#region Q3

            //// int age = int.Parse(Console.ReadLine());
            ////Console.WriteLine(age);



            //int age;
            //int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine(age);

            //#endregion

            //*********************************************************************
            //#region Q4

            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            ////  What happens: This code throws a runtime exception
            ////why: s contains "12a", which is not a valid integer
            ////int.Parse() can only convert strings that contain numeric characters(e.g., "12")
            ////The letter "a" makes the string invalid for integer conversion

            //#endregion

            //*********************************************************************
            //#region Q5

            //string s = "12a";
            //int x;

            //if (int.TryParse(s, out x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            //#endregion

            //*********************************************************************
            #region Q6
            // print :11
            //why : i generate an object with int type then i convert it into int and add 1 to it so no proplem

            #endregion
            //*************************************************************************        

            //#region Q7
            ////unboxing requires the exact original type (int)

            //object o = 10;

            //long x = Convert.ToInt64(o);
            //Console.WriteLine(x);
            //#endregion
            //*******************************************************************
            //#region Q8
            //object o = 10;
            //long x;

            //try
            //{
            //    x = Convert.ToInt64(o);
            //}
            //catch
            //{
            //    x = -1;
            //}

            //Console.WriteLine(x);
            //#endregion
            //*******************************************************************

            //#region Q9
            //string? name = null;
            //Console.WriteLine(name?.Length);
            ////prints null as an empty line
            ////? after string means name can be null.\ So name is currently null
            ////It safely accesses Length only if name is not null
            //#endregion

            //*******************************************************************          
            //#region Q10
            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);
            ////name2 is a nullable string
            ////Since name2 is null, name2?.Length evaluates to null
            ////?? provides a default value if the left-hand side is null
            ////get 0
            //#endregion
            //*******************************************************************           
            //#region Q11
            ////it onle run when s is null or invalid cannot handle the case when s is invalid string before update it

            //string? s = "12a";
            //int x;

            //if (!int.TryParse(s, out x))
            //{
            //    x = 0; // Default value if s is null or invalid
            //}

            //Console.WriteLine(x); // Output: 0
            //#endregion

            //*******************************************************************
            //#region Q12
            ////s!.Length :It tells the compiler: “I promise s is not null, so don’t give me a warning.”
            ////and s is = null that make an error

            //string? s = null;
            //Console.WriteLine(s?.Length ?? 0); // Output: 0 if s is null
            //#endregion

            //**************************************
            //#region Q13
            ////s is a nullable string and currently null
            ////Convert.ToInt32(s) : If the input is null, it returns 0

            //string? s = null;
            //int x = Convert.ToInt32(s); // returns 0 if s is null
            //Console.WriteLine(x);        // Output: 0
            //#endregion


            #region Q14
            //int.Parse does not handle null—it only converts non-null strings like "123".
            //Convert.ToInt32 when you want null to be treated as 0.
            #endregion

            #region Q15

            string? user = null;
            Console.WriteLine((user ?? "Guest").ToUpper());
            #endregion

        }
    }
}
