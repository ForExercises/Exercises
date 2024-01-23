using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            do
            {

                try
                {
                    Console.WriteLine("Shemoitane  ricxvi ");
                    int ricx = int.Parse(Console.ReadLine());
                    result = 10 / ricx;
                    Console.WriteLine(result);

                }
                catch (FormatException exp)
                {

                    Console.WriteLine(exp.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            } while (result == 0);
        }
    }
}
