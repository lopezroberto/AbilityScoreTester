using System;

namespace AbilityScoreTester
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                Console.WriteLine("");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + "[" + lastUsedValue + "]: ");
            string strInput = Console.ReadLine();
            if (int.TryParse(strInput, out int intInput))
            {
                Console.WriteLine("    using value " + intInput);
                return intInput;
            }
            else
            {
                Console.WriteLine("    using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + "[" + lastUsedValue + "]: ");
            string strInput = Console.ReadLine();
            if (double.TryParse(strInput, out double dblInput))
            {
                Console.WriteLine("    using value " + dblInput);
                return dblInput;
            }
            else
            {
                Console.WriteLine("    using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
