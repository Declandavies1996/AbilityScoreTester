using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreTester
{
    public class ReadResponses
    {
        /// <summary>
        /// Writes a prompt and reads an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse</returns>
        public static int ReadInt(int lastUsedValue, string prompt)
        {
            // Write the prompt followed by [default value]:
            Console.WriteLine(prompt + "[" + lastUsedValue + "]");

            // Read the line from the input and use int.TryParse to attempt to parse it
            string response = Console.ReadLine();

            // If it can be parsed, write " using value" + value to the console
            if (int.TryParse(response, out int value))
            {
                Console.WriteLine(value + " using value");

                return value;
            }
            // Otherwise write " using default value" + lastUsedValue to the console
            else
            {
                Console.WriteLine("using default value " + lastUsedValue);

                return lastUsedValue;
            }
        }
        public static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine(" using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
