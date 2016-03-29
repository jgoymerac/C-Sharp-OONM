using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Hmwk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            float num;
            Norm1<float> norm;




            Console.WriteLine("Enter the file name:");
            string filename = Console.ReadLine();
            try
            {
                using( StreamReader sr = new StreamReader(filename))
                {

                }
            }

        }
    }
}
