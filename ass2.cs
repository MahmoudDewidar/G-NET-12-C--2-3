using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════
            the preprocessor directives in C# used to group and organize sections of code into collapsible blocks

            //Nested Region Example
            #region Main Section

            #region Initialization
            int a = 5;
            int b = 10;
            #endregion

            #region Processing
            int sum = a + b;
            Console.WriteLine(sum);
            #endregion

            #endregion


            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
            //means you manually specify the data type of the variable when declaring it
            int number = 10;
            string name = "Mahmoud";
            double price = 99.5;
            bool isActive = true;

            // IMPLICIT DECLARATION 
            //uses the var keyword, where the compiler automatically determines the data type based on the assigned value
            var variableName = value;

            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════


            const datatype ConstantName = value;

            // Constant examples
            const int MaxStudents = 30;
            const double Pi = 3.14159;
            const string UniversityName = "Cairo University";
            const bool IsActive = true;
            //A constant value cannot be modified after it is declared.
            //Improves Code Safety Prevents accidental changes to important values

            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════

            //Class-level scope :
            //refers to variables that are declared inside a class but outside any method.
            class Student
        {
            // Class-level variable (field)
            string name = "Ali";

            public void DisplayName()
            {
                // Accessible here
                Console.WriteLine(name);
            }

            public void ChangeName()
            {
                // Also accessible here
                name = "Omar";
            }
        }
        //Method-level scope:
        //refers to variables that are declared inside a method. These variables are only accessible within that method.
        class Calculator
        {
            public void Add()
            {
                // Method-level variable (local variable)
                int a = 5;
                int b = 10;
                int sum = a + b;

                Console.WriteLine(sum);
            }

            public void Show()
            {
            }
        }



        #endregion

        #region Question 5: Block-level Scope
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 5: BLOCK-LEVEL SCOPE
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is block-level scope? Give an example showing a variable that 
        //    is only accessible within a specific block.
        //
        // ══════════════════════════════════════════════════════════════════════

        // Block-level scope refers to variables that are declared inside a specific block of code(such as { } in if, for, while, or any code block).
        //These variables are only accessible within that block and cannot be used outside of it.
        class Program
        {
            static void Main()
            {
                if (true)
                {
                    // Block-level variable
                    int number = 10;
                    Console.WriteLine(number); // ✅ Accessible inside the block
                }

                // Console.WriteLine(number); 
                //  'number' does not exist in the current context
            }
        }

        #endregion

        #region Question 6: Variable Lifetime - Local vs Static
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is variable lifetime? Explain the lifetime of local variables 
        //    vs static variables.
        //
        // ══════════════════════════════════════════════════════════════════════

        //What is Variable Lifetime?

        //Variable lifetime refers to the duration of time a variable exists in memory during program execution.
        //It starts when the variable is created and ends when it is destroyed or no longer accessible.
        //Local Variables:
        //Created when the method is called - Destroyed when the method ends - Cannot retain its value between method calls
        //Static Variables:
        //Created once when the program starts - Shared among all objects of the class - Retains its value between method calls

        #endregion

        #region Question 7: Garbage Collector
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 7: GARBAGE COLLECTOR
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is the Garbage Collector in C#? How does it affect the 
        //    lifetime of objects?
        //
        // ══════════════════════════════════════════════════════════════════════
        //The Garbage Collector (GC) in C# is an automatic memory management system in the
        //.NET runtime that reclaims memory occupied by objects that are no longer in use
        //how does it affect the lifetime of objects?
        //1-Object Lifetime Depends on Reference
        //2-GC Does NOT Destroy Objects Immediately
        //3-Managed Heap and Generations

        #endregion

        #region Question 8: Variable Shadowing
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 8: VARIABLE SHADOWING
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is variable shadowing in C#? Does C# allow shadowing in 
        //    nested blocks within the same method?
        //
        // ══════════════════════════════════════════════════════════════════════
        //Variable shadowing occurs when a variable declared in an inner scope has the same
        //name as a variable in an outer scope, causing the inner variable to temporarily “hide” or shadow the outer one.
        //C# does allow variable shadowing in nested blocks within the same method
        #endregion

        #region Question 9: C# Naming Rules
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 9: C# NAMING RULES
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: List five rules that must be followed when naming variables in C#.
        //
        // ══════════════════════════════════════════════════════════════════════
        //Must Start with a Letter or Underscore
        //No Spaces Allowed or Special Characters
        //Case-Sensitive
        //Cannot Be a Reserved Keyword
        //Should Follow Naming Conventions
        #endregion

        #region Question 10: Naming Conventions
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 10: NAMING CONVENTIONS
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What naming conventions are recommended for: (a) local variables, 
        //    (b) class names, (c) constants?
        //
        // ══════════════════════════════════════════════════════════════════════
        //naming conventions
        //naming conventions are guidelines that help make code readable, maintainable, and consistent
        //Local Variables:-Convention: camelCase
        //Class Names:-Convention: PascalCase
        //Constants:-Convention: UPPERCASE_WITH_UNDERSCORES
        #endregion

        #region Question 11: Error Types
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 11: ERROR TYPES
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Compare and contrast syntax errors, runtime errors, and logical 
        //    errors. Provide an example of each.
        //
        // ══════════════════════════════════════════════════════════════════════
        //syntax errors:Occur when the code violates C# language rules Detected by the compiler Program cannot compile until fixed
        class Program
        {
            static void Main()
            {
                int number = 10
                Console.WriteLine(number);
            }
        }
        Error: Missing semicolon; after int number = 10
        //runtime errors:Occur during program execution Detected when the code runs Program may crash or throw exceptions
        class Program
        {
            static void Main()
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // Accessing invalid index
            }
        }
        Error: IndexOutOfRangeException
        //logical errors:Occur when the code runs without crashing but produces incorrect results Detected through testing and debugging Program behaves unexpectedly
        class Program
        {
            static void Main()
            {
                int a = 10, b = 5;
                int result = a - b; // Mistakenly using subtraction instead of addition
                Console.WriteLine(result); // Output: 5, but expected 15
            }
        }

        #endregion

        #region Question 12: Exception Handling Importance
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Why is exception handling important in C#? What would happen if 
        //    you don't handle exceptions?
        //
        // ══════════════════════════════════════════════════════════════════════
        //Exception handling in C# is a way to gracefully manage runtime errors using constructs like try, catch
        //Exception handling is crucial for building robust, user-friendly, and maintainable programs.
        //Without it, runtime errors cause crashes, disrupt program flow, and may leave resources uncleaned.
        //With it, you can catch errors, recover gracefully, and log problems for debugging.

        #endregion

        #region Question 13: try-catch-finally
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 13: TRY-CATCH-FINALLY
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Write a code example demonstrating try-catch-finally. Explain when 
        //    the finally block executes.
        //
        // ══════════════════════════════════════════════════════════════════════
        using System;

class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                int result = 100 / number; // May cause DivideByZeroException
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Execution of try-catch block is complete.");
            }

            Console.WriteLine("Program continues...");
        }
    }

    #endregion

    #region Question 14: Common Built-in Exceptions
    // ══════════════════════════════════════════════════════════════════════
    // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
    // ══════════════════════════════════════════════════════════════════════
    //
    // Q: List and explain five common built-in exceptions in C# with 
    //    scenarios when each would occur.
    //
    // ══════════════════════════════════════════════════════════════════════
    // NullReferenceException:- Thrown when you try to use an object reference that is null.
    //indexOutOfRangeException:- Thrown when you try to access an array or collection element with an index that is out of bounds.
    //DivideByZeroException:- Thrown when you attempt to divide an integer by zero.
    // FormatException:- Thrown when the format of an argument is invalid, such as when parsing a string to a number.
    // InvalidOperationException:- Thrown when a method call is invalid for the object's current state
    #endregion

    #region Question 15: Multiple catch Blocks
    // ══════════════════════════════════════════════════════════════════════
    // QUESTION 15: MULTIPLE CATCH BLOCKS
    // ══════════════════════════════════════════════════════════════════════
    //
    // Q: Why is the order of catch blocks important when handling multiple 
    //    exceptions? Write code showing correct ordering.
    //
    // ══════════════════════════════════════════════════════════════════════
    using System;

class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num; // May throw DivideByZeroException
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex) // Specific exception
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (DivideByZeroException ex) // Another specific exception
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (Exception ex) // General exception (catch-all)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution complete.");
            }
        }
    }

    #endregion

    #region Question 16: throw Keyword
    // ══════════════════════════════════════════════════════════════════════
    // QUESTION 16: THROW KEYWORD
    // ══════════════════════════════════════════════════════════════════════
    //
    // Q: What is the difference between 'throw' and 'throw ex' when 
    //    re-throwing an exception? Which one preserves the stack trace?
    //
    // ══════════════════════════════════════════════════════════════════════
    //throw: Re-throws the current exception without altering it.
    //throw ex: Re-throws the exception but resets the stack trace to the point of the throw statement, losing the original stack trace.
    #endregion

    #region Question 17: Stack and Heap Memory
    // ══════════════════════════════════════════════════════════════════════
    // QUESTION 17: STACK AND HEAP MEMORY
    // ══════════════════════════════════════════════════════════════════════
    //
    // Q: Explain the differences between Stack and Heap memory in C#. 
    //    What types of data are stored in each?
    //
    // ══════════════════════════════════════════════════════════════════════
    // Stack Memory : Stack is a region of memory that stores local variables, method parameters, and function call information
    //Stores value types (int, float, bool, struct
    //heap:  is a region of memory for dynamic memory allocation
    //Stores reference types (class, string, arrays, objects).

    #endregion

    #region Question 18: Value Types vs Reference Types
    // ══════════════════════════════════════════════════════════════════════
    // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
    // ══════════════════════════════════════════════════════════════════════
    //
    // Q: Write a code example showing how value types and reference types 
    //    behave differently when assigned to another variable.
    //
    // ══════════════════════════════════════════════════════════════════════
    //value types
    int a = 10;    // Value type
        int b = a;     // Copy of 'a'
b = 20;

Console.WriteLine(a); // Output: 10 (unchanged)
Console.WriteLine(b); // Output: 20
//reference types
class Student
    {
        public string Name;
}

Student s1 = new Student();
s1.Name = "Ali";

Student s2 = s1; // Copy of reference, both point to the same object
    s2.Name = "Omar";

Console.WriteLine(s1.Name); // Output: Omar
Console.WriteLine(s2.Name); // Output: Omar

    #endregion

    #region Question 19: Object in C#
    // ══════════════════════════════════════════════════════════════════════
    // QUESTION 19: OBJECT IN C#
    // ══════════════════════════════════════════════════════════════════════
    //
    // Q: Why is 'object' considered the base type of all types in C#? 
    //    What methods does every type inherit from System.Object?
    //
    // ══════════════════════════════════════════════════════════════════════
    //object Is the Base Type very type in C# (including int, double, string, class, struct) ultimately inherits from System.Object.
    //Methods Inherited from System.Object
    //1.ToString():
    //2.Equals(object obj)
     //3.GetHashCode()
     //4.GetType()
     // 5.MemberwiseClone()

    #endregion

}


#endregion
}

    
}