namespace Algorithms.General
{
    public class OrderofNumber
    {
        //static void Main()
        //{
        //    long num = 12345678912365;
        //    var result = Order(num);
        //    Console.WriteLine(result);
        //}

        public static int Order(long n)
        {
            int order = 0;
            long temp = n;
            while (temp != 0)
            {
                order++;
                temp = temp / 10;
            }

            return order;
        }
    }
}
