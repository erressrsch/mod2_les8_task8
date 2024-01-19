using System;
class Program
{
    static void Main()
    {
        string test = "Abcdefg";
        string revers = string.Empty;

        for (int i = test.Length - 1; i >= 0; i--)
        {
            if (i == test.Length - 1)
            {
                revers += test[i].ToString().ToUpper();

            }
            else if (i == 0)
            {
                revers = test[i].ToString().ToLower();
            }
            else
            {
                revers += test[i].ToString();
            }


        }
        Console.WriteLine($"Input string: {test}");
        Console.WriteLine($"Output string: {revers}");
    }
}
