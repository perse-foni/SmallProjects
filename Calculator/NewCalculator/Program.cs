using System;

namespace NewCalculator
{
    class Program
    {

        private const double minValueDouble = -1000;
        private const double maxValueDouble = 1000;
        private const int minQtyInt = 2;
        private const int maxQtyInt = 10;


        public static void Main(string[] args)
        {
          
            double inputDouble = 0;
            double totalDouble = 0;
            bool okBool = true;
            int quantityInt;

            double[] inputValuesDoubleArray;

            Console.WriteLine("Welcome to my new calculator");
            Console.WriteLine("");

            Console.WriteLine("Enter how many numbers do you want to add (values between 2 and 10): ");
            quantityInt = int.Parse(Console.ReadLine());

            if ((quantityInt < minQtyInt) || (quantityInt > maxQtyInt))
            {
                Console.WriteLine("\nQuantity, {0}, is not within range of {1} and {2}.Re-enter the value\n",
                    quantityInt, minQtyInt, maxQtyInt);
            }
            else
            {

                inputValuesDoubleArray = new double[quantityInt];

                for (int indexInt = 0; indexInt < quantityInt; indexInt++)
                {
                    okBool = false;

                    do
                    {
                        Console.WriteLine("\nEnter number: ");
                        inputDouble = double.Parse(Console.ReadLine());

                        if ((inputDouble < minValueDouble) || (inputDouble > maxValueDouble))
                        {
                            Console.WriteLine(
                                "\nInput number, {0}, is not within range of {1} and {2}.Re-enter the value\n",
                                inputDouble, minValueDouble, maxValueDouble);
                            okBool = false;
                        }
                        else
                        {
                            inputValuesDoubleArray[indexInt] = inputDouble;
                            okBool = true;
                        }
                    } while (okBool == false);
                }
                for (int indexInt = 0; indexInt < quantityInt; indexInt++)
                {
                    totalDouble += inputValuesDoubleArray[indexInt];

                }




                Console.WriteLine("\n Total: {0}\n", totalDouble);
            }
        }

    }
}