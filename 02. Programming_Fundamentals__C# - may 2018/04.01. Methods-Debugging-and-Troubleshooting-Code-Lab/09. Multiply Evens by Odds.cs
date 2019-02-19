using System;

class test
{
    static void Main()
    {
        int num = Math.Abs(int.Parse(Console.ReadLine()));
        int sum = MultiplyEvensByOdds(num);

        Console.WriteLine(sum);
    }

    static int MultiplyEvensByOdds(int num)
    {
        int sumEven = 0;
        int sumOdd = 0;

        while (num > 0)
        {
            int lastDigit = num % 10;

            if (lastDigit % 2 == 0)
            {
                sumEven += lastDigit;
            }
            else
            {
                sumOdd += lastDigit;
            }

            num /= 10;
        }

        return sumEven * sumOdd;
    }
}