using System;

namespace Calculator1
{
    public class CMethods
    {


        double Nummer1 { get; set; }
        double Nummer2 { get; set; }
        string Counter { get; set; }
        double total;


        public CMethods() { }


        public CMethods(double tal1, double tal2)
        {
            Nummer1 = tal1;
            Nummer2 = tal2;
        }



        public double Add(double a, double b)
        {
            Nummer1 = a;
            Nummer2 = b;

            return a + b;
        }



        public double Add(double[] addNumbers)
        {
            double result = 0;
            for (int i = 0; i < addNumbers.Length; i++)
                result += addNumbers[i];

            return result;
        }

        public double Subtract(double a, double b)
        {
            Nummer1 = a;
            Nummer2 = b;


            return a - b;
        }

        public double Subtract(double[] subtractNumbers)
        {
            double sum = 0;
            for (int i = 0; i < subtractNumbers.Length; i++)
            {
                sum = subtractNumbers[0];
            }
            for (int i = 1; i < subtractNumbers.Length; i++)
            {
                sum = sum - subtractNumbers[i];
            }
            return sum;
        }

        public double Multiply(double a, double b)
        {
            Nummer1 = a;
            Nummer2 = b;

            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Du försöker dela med noll");
                Console.WriteLine("Nytt tal");
                b = Convert.ToDouble(Console.ReadLine());
                return a / b;
            }
        }

        
    }
}








