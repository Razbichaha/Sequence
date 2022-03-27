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

            for(int i=beginningSequnce;i<=stopCicle;i+=stepCicle)
            {
                Console.WriteLine(i);
            }
        }
    }
}
