using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sales Amount...");


            try
            {
                //this will take the users input
                string input = Console.ReadLine();

                decimal sales = decimal.Parse(input);
                //this will calculate the bonus
                decimal bonus = 0;
                //this will hold the number of yuears
                int years_in_sales = 0;

                if (sales < 1000)
                {
                    bonus += .05m * sales;
                    Console.WriteLine("Your 5% bonus for the Sales Amount " + String.Format("{0:C}", sales) + " is: " + String.Format("{0:C}", sales));
                    //the number of years the user will be in sales
                    Console.WriteLine("How many years have you been in Sales?");
                    //number of years the user has input to the yars in sales var
                    years_in_sales = int.Parse(Console.ReadLine());

                    switch (years_in_sales)
                    {
                        case 0:
                            Console.WriteLine("Wow, solid play for a rookie!");
                            Console.WriteLine("Press any key to exit");
                            //the line below will pause the program
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Not bad for one year of sales");
                            Console.WriteLine("Press a key to exit the program");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Not bad for two years in sales");
                            Console.WriteLine("press any key to exit");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("You have many years of sales, keep up the good work!");
                            Console.WriteLine("If you are here by error please try again");
                            Console.WriteLine("Press any key to exit the program");
                            break;
                        //this is the end of the switch
                    }
                }
                else if ((sales > 1000) && (sales < 3000))
                {
                    bonus += .06m * sales;
                    Console.WriteLine("Your 6% bonus for the Sales amount " + String.Format("{0:C}", sales) + " is: " + String.Format("{0:C}", bonus));
                    Console.WriteLine("How many years have you been in sales?");
                    //assign the number of years for the sales variable
                    years_in_sales = int.Parse(Console.ReadLine());
                    
                    switch (years_in_sales)
                    {
                        case 0:
                            Console.WriteLine("Wow, solid play for a rookie!");
                            Console.WriteLine("Press any key to exit");
                            //the line below will pause the program
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Not bad for one year of sales");
                            Console.WriteLine("Press a key to exit the program");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Not bad for two years in sales");
                            Console.WriteLine("press any key to exit");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("You have many years of sales, keep up the good work!");
                            Console.WriteLine("If you are here by error please try again");
                            Console.WriteLine("Press any key to exit the program");
                            break;

                            //end of switch
                    }
                }
                else
                {
                    bonus += .07m * sales;
                    Console.WriteLine("Your 7% bonus for the sales amount " + String.Format("{0:C}", sales) + " is: " + String.Format("{0:C}", bonus));
                    Console.WriteLine("How many yars have you been in sales?");
                    //assigned the number of years the user can input in the var
                    years_in_sales = int.Parse(Console.ReadLine());

                    switch (years_in_sales)
                    {
                        case 0:
                            Console.WriteLine("Wow, solid play for a rookie!");
                            Console.WriteLine("Press any key to exit");
                            //the line below will pause the program
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Not bad for one year of sales");
                            Console.WriteLine("Press a key to exit the program");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Not bad for two years in sales");
                            Console.WriteLine("press any key to exit");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("You have many years of sales, keep up the good work!");
                            Console.WriteLine("If you are here by error please try again");
                            Console.WriteLine("Press any key to exit the program");
                            break;

                            //end of switch
                    }
                }
            } //end of try
            catch
            {
                Console.WriteLine("Please use a decimal data type for you sales amount next time");
                Console.WriteLine("-----OR -----");
                Console.WriteLine("Please use an integer data type for your number of years in sales next time...");
                Console.WriteLine("Press any key to exitr the program and try again");
                Console.ReadKey(true);
            } //end of catch
        } //end of main
    }// end of class
} // end of namespace
