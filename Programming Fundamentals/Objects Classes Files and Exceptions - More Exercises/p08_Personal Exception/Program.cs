using System;

namespace p08_Personal_Exception
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                var num = int.Parse(Console.ReadLine());
                try
                {
                    if (num < 0)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine(num);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                
            }
        }
    }

    public class Exception : System.Exception
    {
        public Exception(string message) : base(message)
        {
        }
    }
}