using System;
using System.Linq;
using System.Text;

class AdditionAlgorithm
{
    static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        int maxLen = Math.Max(num1.Length, num2.Length);
        num1 = num1.PadLeft(maxLen, '0');
        num2 = num2.PadLeft(maxLen, '0');
        int remind = 0;
        StringBuilder result = new StringBuilder();

        for (int i = maxLen - 1; i >= 0; i--)
        {
            int firstDigit = int.Parse(num1[i].ToString());
            int secondDigit = int.Parse(num2[i].ToString());
            int currentSum = firstDigit + secondDigit + remind;
            remind = 0;

            if (currentSum > 9)
            {
                currentSum -= 10;
                remind++;
            }

            result.Append(currentSum);
        }

        result.Append(remind);
        string output = result.ToString().TrimEnd('0');

        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.Write(output[i]);
        }
    }
}