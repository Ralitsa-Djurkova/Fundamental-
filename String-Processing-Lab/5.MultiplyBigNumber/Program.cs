using System;
using System.Text;

namespace _5.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNumber = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();
            int remeinder = 0;
            for (int i = reallyBigNumber.Length - 1; i > 0; i--)
            {
                int result = int.Parse(reallyBigNumber[i].ToString()) * num + remeinder;
                remeinder = 0;

                if(result > 9)
                {
                    remeinder = result / 10;
                    result = result % 10;
                }
                sb.Append(result);

                if(remeinder != 0)
                {
                    sb.Append(remeinder);
                }
            }

            StringBuilder finalresult = new StringBuilder();

            for (int i = sb.Length - 1; i > 0; i--)
            {
                finalresult.Append(sb[i]);
            }
        }
    }
}
