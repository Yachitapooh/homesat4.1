using System;

namespace homesat_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int layer = int.Parse(Console.ReadLine());           
            while (layer < 0) 
            {
                if (layer < 0) 
                {
                    Console.WriteLine(" Invalid Pascal's triangle row number.");

                    int layer2 = int.Parse(Console.ReadLine());
                    layer = layer2;                   
                }
            }
            pas(layer);
            
            static void pas (int layer) 
            {
                int num = 0, i, j;
                for (i = 0; i <= layer; i++) 
                {
                    for (j = 0; j <= i; j++) 
                    {
                        if (j == 0 || i == 0)
                        {
                            num = 1;
                        }
                        else 
                        {
                            num = num * ((i - j) + 1) / j;                       
                        }
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
