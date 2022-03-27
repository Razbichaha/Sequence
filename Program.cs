using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningSequnce=5;
            int stopCicle = 96;
            int stepCicle = 7;

            do
            {
                Console.WriteLine(beginningSequnce);
            } while ((beginningSequnce=beginningSequnce+stepCicle)<=stopCicle);
        }
    }
}
