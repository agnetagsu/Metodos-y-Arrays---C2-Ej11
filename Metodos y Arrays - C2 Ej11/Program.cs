using System;

namespace Metodos_y_Arrays___C2_Ej11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarray = new int[10];
            int misuma = 0;

            for (int i = 0; i < miarray.Length; i++)
            {
                miarray[i] = i;
                misuma = misuma + i;
            }
          
            Console.WriteLine(misuma);
            
        }
    }
}
