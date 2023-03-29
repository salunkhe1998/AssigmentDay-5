using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    public class GenericMethod
    {
        public static int size;
        public static void DeleteIntElement(int[] arry, int delete)
        {
            int k = 0;
            int[] result = new int[arry.Length - 1];

            for (int i = 0; i < arry.Length; i++)
            {
                if (delete != arry[i])
                {
                    result[k] = arry[i];
                    k++;
                }
            }
            Console.WriteLine("\nResult After Delete Element ");
            foreach (int j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static void DeleteDoubleElement(double[] arry, double delete)
        {
            int k = 0;
            double[] result = new double[arry.Length - 1];

            for (int i = 0; i < arry.Length; i++)
            {
                if (delete != arry[i])
                {
                    result[k] = arry[i];
                    k++;
                }
            }

            Console.WriteLine("\nResult After Delete Element ");
            foreach (double j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static void DeleteCharElement(char[] arry, char delete)
        {
            int k = 0;
            char[] result = new char[arry.Length - 1];

            for (int i = 0; i < arry.Length; i++)
            {
                if (delete != arry[i])
                {
                    result[k] = arry[i];
                    k++;
                }
            }

            Console.WriteLine("\nResult After Delete Element ");
            foreach (char j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static int[] GetIntElement()
        {
            Console.WriteLine("Enter How many elements you want to add into array.");
            DeleteArrayElement.size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[DeleteArrayElement.size];
            Console.WriteLine("Please enter elements one by one");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static double[] GetDoubleElement()
        {
            Console.WriteLine("Enter How many elements you want to add into array");
            DeleteArrayElement.size = Convert.ToInt32(Console.ReadLine());
            double[] doubleArry = new double[DeleteArrayElement.size];
            Console.WriteLine("Please enter Double element one by one");
            for (int i = 0; i < doubleArry.Length; i++)
            {
                doubleArry[i] = Convert.ToDouble(Console.ReadLine());
            }
            return doubleArry;
        }

        public static char[] GetCharElement()
        {
            Console.WriteLine("Enter How many elements you want to add into array");
            DeleteArrayElement.size = Convert.ToInt32(Console.ReadLine());
            char[] charArry = new char[DeleteArrayElement.size];
            Console.WriteLine("Please enter charachter element one by one");
            for (int i = 0; i < charArry.Length; i++)
            {
                charArry[i] = Convert.ToChar(Console.ReadLine());
            }
            return charArry;
        }

        public static void DeleteElementFromArray<T>(T[] arr, T element)
        {
            int k = 0;
            T[] result = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals(element))
                {
                    result[k] = arr[i];
                    k++;
                }
            }

            Console.WriteLine("\nResult After Delete Element ");
            foreach (T j in result)
            {
                Console.Write(j + " ");
            }
        }

    }
}