using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Programm2
    {
        public static void main()
        {
            int[] arr = new int[15]
                .Select(x => new Random().Next(100)).ToArray().Print();
          arr = arr.Select(x => x < 0 ? -x : x ).ToArray().Print();
          arr = arr.Where(x => x != 0 ).ToArray().Print();
          arr = arr.Where(x => x % 2 == 0).ToArray().Print();


        }
    }
}