using System;
using NUnit.Framework;

namespace PingPongLibrary
{
    

    public class PingPonger
    {

        public static int GetPrimes(int input)
        {
            return 2;
        }

        public static bool CheckPrimes(int input)
        {
            // if(input == 1 || input == 4)
            // return false;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                    return false;
            }
            return true;
        }
    }
}
