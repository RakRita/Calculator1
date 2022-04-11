using System;

namespace Calculator1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CMethods cM = new CMethods();
            Console.WriteLine("ange nummer");

            double[] a = new double[] { 7, 5, 10 };

            Console.WriteLine(cM.Subtract(a));
            Console.WriteLine(cM.Divide(8, 4));

            Console.WriteLine(cM.Subtract(8.88, 7.0));

            double nr1;
            double nr2;
            string firstNumStr;
            string op;
            bool calculate = true;

            while (calculate)
            {
                Console.WriteLine("Welcome to the calculator");
                Console.WriteLine("Press x to exit");


                Console.WriteLine();
                Console.WriteLine("Skriv in ett nummer, och tryck Ener");

                firstNumStr = Console.ReadLine();



                if (firstNumStr == "x")
                {
                    calculate = false;
                }
                nr1 = Convert.ToDouble(firstNumStr);


                Console.WriteLine("Välj ett av följande val");
                Console.WriteLine("+   addition");
                Console.WriteLine("-   subraktion");
                Console.WriteLine("/   division");
                Console.WriteLine("*   multiplikation");

                op = Console.ReadLine();


                Console.WriteLine("Skriv in ett annat nummer, och tryck Enter");
                nr2 = Convert.ToDouble(Console.ReadLine());


                switch (op)
                {
                    case "+":
                        Console.WriteLine(cM.Add(nr1, nr2).ToString());
                        break;

                    case "-":
                        Console.WriteLine(cM.Subtract(nr1, nr2).ToString());
                        break;
                    case "/":
                        Console.WriteLine(cM.Divide(nr1, nr2).ToString());
                        break;
                    case "*":
                        Console.WriteLine(cM.Multiply(nr1, nr2).ToString());
                        break;

                }

            }
            Console.WriteLine("GoodBye");
            Console.ReadLine();
        }
    }
}




