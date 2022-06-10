using System;

namespace ExHandling1
{
    namespace Bai05
    {
        class Vidu1
        {
            static void Main(string[] args)
            {
                byte[] a = new byte[5];

                //Enter Array
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("a[{0}] = ", i+1);
                        a[i] = Convert.ToByte(Console.ReadLine());
                    }
                }
                catch (FormatException ex)
                {
                    //Console.WriteLine(ex.Message);
                    Console.WriteLine("Khong duoc nhap ky tu cho mang so");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //print Array
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" {0} ", a[i]);
                }
            }
        }
    }
}
