class Program
{
    /// <summary>
    ///  Tribonacci function that given a signature array/list, returns the 
    ///  first n Tribonacci elements - signature included of the so seeded sequence.
    /// </summary>
    /// <param name="signature">First digits of sequence</param>
    /// <param name="n">Number of elements in resulting array</param>
    /// <returns>Tribonacci sequence</returns>
    public static double[] Tribonacci(double[] signature, int n)
    {

        if (signature.Length < 3) throw new ArgumentOutOfRangeException("First sequence must contain minimum 3 elements");
        else if (n <= 3) throw new ArgumentOutOfRangeException("Sequence length must be greater than 3");
        else if (signature.Any(num => num < 0)) throw new ArgumentOutOfRangeException("Numbers in sequence must be greater or equal to zero");
        else if (signature.Sum() == 0) { Console.WriteLine("All numbers in sequence are zeroes"); return new double[0]; }

        double[] result = new double[n];
        for (int i = 0; i < n; i++)
        {
            if (i < signature.Length) result[i] = signature[i];                 //first sequence given from parameters
            else result[i] += result[i - 1] + result[i - 2] + result[i - 3];    //calculating 
        }
        return result;
    }

    static void Main()
    {
        double[] zeroes = new double[] { 0, 0, 0 };
        double[] firstZero = new double[] { 0, 0, 1 };
        double[] firstOne = new double[] { 1, 1, 1 };

        double[] test0 = Tribonacci(zeroes, 20);
        double[] test1 = Tribonacci(firstZero, 20);
        double[] test2 = Tribonacci(firstOne, 20);

        foreach (double d in test0) { Console.Write($"{d} "); }                 //zeroes
        foreach (double d in test1) { Console.Write($"{d} "); }
        Console.WriteLine();
        foreach (double d in test2) { Console.Write($"{d} "); }

        //wrong parameters test
        //double[] wrong1 = new double[] { 0, 1 };
        //double[] wrong2 = new double[] { -2, -1 };
        //double[] wrong3 = new double[] { };
        //double[] wrong4 = null;
        //double[] wrong5 = new double[] { -3, -2, -1 };

        //double[] test3 = Tribonacci(wrong1,  20);
        //double[] test4 = Tribonacci(wrong2,  20);
        //double[] test5 = Tribonacci(wrong3, 20);
        //double[] test6 = Tribonacci(wrong4, 20);
        //double[] test7 = Tribonacci(firstZero, 3);
        //double[] test8 = Tribonacci(wrong5, 20);
    }
}