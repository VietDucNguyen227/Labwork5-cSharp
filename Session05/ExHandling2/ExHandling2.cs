using System;

namespace ExHandling2
{
    public class InvalidInput : ApplicationException
    {
        public InvalidInput() : base("Enter a number greater than Zero") { }
    }

    class TestExcep
    {
        static void Main()
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Enter a number : ");
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInput();
                }
            }
            catch (InvalidInput objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                    {
                        Console.WriteLine(intCnt * intNum);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}   

