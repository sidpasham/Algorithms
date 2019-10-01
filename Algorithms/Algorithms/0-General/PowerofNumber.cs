namespace Algorithms.General
{
    public class PowerofNumber
    {
        //static void Main()
        //{
        //    var result = Power(10, 5);
        //    Console.WriteLine(result);
        //}

        public static double Power(int a, int b)
        {
            if (b == 0) return 1;
            if (b % 2 == 0)
                return Power(a, b / 2) * Power(a, b / 2);
            return a * Power(a, b / 2) * Power(a, b / 2);
        }
    }

}
