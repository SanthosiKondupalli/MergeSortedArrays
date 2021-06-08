using System;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the First array");
            String Str = Console.ReadLine();
            int Ar1_Size = Convert.ToInt32(Str);
            
            int[] Ar1 = new int[Ar1_Size];
            Console.WriteLine("Enter " + Ar1_Size + " elements of first arrray in sorted manner");
            for (int i = 0; i < Ar1_Size; i++)
            {
                Str = Console.ReadLine();
                Ar1[i] = Convert.ToInt32(Str);
            }
            Console.WriteLine("Enter the size of the Second array");
            Str = Console.ReadLine();
            int Ar2_Actualsize = Convert.ToInt32(Str);
            int Ar2_Size = Ar2_Actualsize + Ar1_Size;

            int[] Ar2 = new int[Ar2_Size];
            Console.WriteLine("Enter " + Ar2_Actualsize + " elements of Second arrray in sorted manner");
            for (int i = 0; i < Ar2_Actualsize; i++)
            {
                Str = Console.ReadLine();
                Ar2[i] = Convert.ToInt32(Str);
            }
            int A1 = Ar1_Size - 1;
            int A2 = Ar2_Actualsize - 1;
            
            for(int i=Ar2_Size-1;i>=0&&A2>=0&&A1>=0;i--)
            {
                if (Ar1[A1] < Ar2[A2])
                {
                    Ar2[i] = Ar2[A2];
                    A2--;
                    

                }
                else if (Ar1[A1] > Ar2[A2])
                {
                    Ar2[i] = Ar1[A1];
                    A1--;

                }
                else
                {
                    Ar2[i] = Ar2[A2];
                    i--;
                    Ar2[i] = Ar1[A1];
                    A1--;
                    A2--;
                }
                
            
            }
            if(A1>=0)
                for(int i=A1;i>=0;i--)
                {
                    Ar2[i] = Ar1[i];
                }
            Console.WriteLine("The merged Array is:");
            for (int i = 0; i < Ar2_Size; i++)
                Console.Write(Ar2[i] + " ");
            
        }



        }
    }

