using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningSequnce=5;

            for(int i = 0; i < 96; i++)
            {
                i = beginningSequnce;
                Console.WriteLine(beginningSequnce);
                Console.ReadLine();
                beginningSequnce = beginningSequnce + 7;
            }
        }
    }
}
