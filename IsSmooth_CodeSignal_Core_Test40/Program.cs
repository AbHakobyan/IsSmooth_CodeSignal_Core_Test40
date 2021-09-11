using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSmooth_CodeSignal_Core_Test40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -12, 34, 40, -5, -12, 4, 0, 0, -12 };
            bool action = isSmooth(array);
            Console.WriteLine(action);
            
        }

        static bool isSmooth(int[] arr)
        {
            int midle;
            int midleleft;
            int midleright;
            if (arr.Length % 2 == 1)
            {
                midle = arr.Length / 2;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[0] == arr[arr.Length - 1] && arr[0] == arr[midle])
                    {
                        return true;
                    }
                }
            }
            else
            {
                midleright = arr.Length / 2;
                midleleft = midleright - 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[0] == arr[arr.Length - 1] && arr[0] == arr[midleright] + arr[midleleft])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
