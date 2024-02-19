using System;
using System.Reflection;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            HasASecret keeper = new HasASecret();

            FieldInfo[] fields = keeper.GetType().GetFields(
                BindingFlags.NonPublic | BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                Console.WriteLine(field.GetValue(keeper));
            }
        }
    }
}
