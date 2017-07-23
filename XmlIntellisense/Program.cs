using System;

namespace XmlIntellisense
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = typeof(Program).Assembly;
            var version = assembly.GetName().Version;
            Console.WriteLine("Version={0}", version);
        }
    }
}
