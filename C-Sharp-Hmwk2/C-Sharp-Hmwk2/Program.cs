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
            Norm1 norm;
            List<CylnCord> list = new List<CylnCord>();



            Console.WriteLine("Enter the file name:");
            string filename = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    x = int.Parse(sr.ReadLine());
                    for (int i = 0; i < x; i++)
                    {
                        string temp = sr.ReadLine();
                        string[] tempSplit = temp.Split(' ');
                        float r, theta, z;

                        r = float.Parse(tempSplit[0]);
                        theta = float.Parse(tempSplit[1]);
                        z = float.Parse(tempSplit[2]);
                        CylnCord tempCord;
                        tempCord = new CylnCord(r, theta, z);


                        list.Add(tempCord);
                    }

                }
                foreach(CylnCord c in list)
                {
                    Console.WriteLine(c);
                }
                

                Console.WriteLine("Reflection of the 1st point thru the origin");
                Console.WriteLine(-list[0]);
                Console.WriteLine("Reflection of 2nd point thru z axis:");
                Console.WriteLine(!list[1]);
                Console.WriteLine("Outputting the lesser of :" + list[2] + " and " + list[3]);
                if (list[2] < list[3])
                {
                    Console.WriteLine(list[2]);
                }
                else
                {
                    Console.WriteLine(list[3]);
                }
                Console.WriteLine(list[4]+ " In cartesian Coordinates is: ");
                Console.WriteLine(list[4].cartCord());
                Console.WriteLine("The L-1-Norm of the vectors is: ");
                num = Norm1.Norm(ref list);
                Console.WriteLine(num);

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}