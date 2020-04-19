using System;

namespace anagramStrings
{

    //     Anagram words

    //    listen --- silent

    //    triangle --- integral


    class Program
    {
        static void Main()
        {

            //int NO_OF_CHARS = 256;

            /* function to check whether two strings 
            are anagram of each other */
            bool areAnagram(char[] str1, char[] str2)
            {
                // Create a count arrays and initialize 
                // all values as 0 
                int[] count1 = new int[256];

                // If both strings are of different length. 
                // Removing this condition will make the program 
                // fail for strings like "aaca" and "aca" 

                if (str1.Length != str2.Length)
                    return false;

                // For each character in input strings, 
                // increment count in the corresponding 
                // count array
                // cuenta la cantidad de veces que se repite un caracter determinado en str1.
                // y guarda esa contidad en el contador count1
                for (int i = 0; i < str1.Length; i++)
                {
                    count1[str1[i]]++;
                }

                // como ya en el primer ciclo count1 tiene la cantidad de veces que se repiten 
                // cada caracter ahora vamos a restar cada ves que tengamos ese caracter.
                // dos arreglos diferentes de la misma logitud y con los caracteres repetidos
                // la misma cantidad de veces es anagrma 

                for (int i = 0; i < str2.Length; i++)
                {
                    count1[str2[i]]--;
                }

                //

                for (int i = 0; i < count1.Length; i++)
                {
                    if (count1[i] != 0)
                        return false;
                }

                return true;
            }



            /* Driver program to test to print printDups*/
           
                char[] str1 = ("listen").ToCharArray();
                char[] str2 = ("zilent").ToCharArray();

                if (areAnagram(str1, str2))
                    Console.WriteLine("The two strings ARE "
                                      + "ANAGRAM of each other");
                else
                    Console.WriteLine("The two strings ARE NOT"
                                      + " ANAGRAM of each other");
            Console.ReadKey();
            
        }

        





    }
}

