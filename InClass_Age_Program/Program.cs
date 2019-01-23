using System;

namespace InClass_Age_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Taking user input for age
                Console.WriteLine("Enter your Age between 18 and 100");
                string input = Console.ReadLine(); // reading from console
                int age = int.Parse(input); // Parsing user input

                if (age > 17 && age <= 100)
                {
                    int get_heart_rate = Max_heart_rate(age); // // calling the function Max_heart_rate(age) and assigning the value returned from the function to a variable
                    Console.WriteLine("The Maximum heart rate is " + get_heart_rate); // Displayimg the results to the console

                } // end of if (age > 17 && age <= 100)

                else
                {
                    Console.WriteLine("Please enter age between 18 and 100");
                } // end of else

                // exit statement
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);

            } // end of try

            // If error occurs in try block, catch block is executed. Else it is not executed
            catch
            {
                Console.WriteLine("Please enter a valid input next time");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } // end of catch

        } // end of main

        // Defining max_heart_rate method
        private static int Max_heart_rate(int age)
        {
            // calculate the max heart rate
            int cal_heart_rate = 220 - age;
            
            // return the heart rate value
            return cal_heart_rate;
        } // end of max_heart_rate

    } //end of class
} // end of namespace
