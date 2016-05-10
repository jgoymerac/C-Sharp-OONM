using System;
using System.Collections.Generic;
using System.IO;

namespace C_Sharp_Hmwk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            float num;
            //Norm1<float> norm;
            List<CylnCord<float>> list= new List<CylnCord<float>>();
                     


            Console.WriteLine("Enter the file name:");
            string filename = Console.ReadLine();
            try
            {
                using( StreamReader sr = new StreamReader(filename))
                {
                    x = int.Parse(sr.ReadLine());
                    for(int i=0;i< x; i++)
                    {
                        string temp = sr.ReadLine();
                        string[] tempSplit = temp.Split(' ');
                        float r, theta, z;
                        
                        r = float.Parse(tempSplit[0]);
                        theta = float.Parse(tempSplit[1]);
                        z = float.Parse(tempSplit[2]);
                        CylnCord<float> tempCord;
                        tempCord.set(r, theta, z);
                        
                        list.Add(tempCord);
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
