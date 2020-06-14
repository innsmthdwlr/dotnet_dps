using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Sum
    {
        public int SumTwo(int a, int b)
        {
            return a+b;
        }

        public string Generate()
        {
            src.FM.IGeneratorTaskFactory factory = new src.FM.CopyTaskFactory();
            src.FM.IGeneratorTask product = factory.CreateGeneratorTask();
            return product.TypeOfGenerator;
        }
    }
}
