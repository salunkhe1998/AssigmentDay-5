using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace GenericDemo
    {
        public class GenericClass<T>
        {
            T[] arr;
            T element;
            public GenericClass(T[] arr, T element)
            {
                this.arr = arr;
                this.element = element;
            }

            public void RemoveElementFromGenericClass()
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

                Console.WriteLine("\nResult After Deleting Element ");
                foreach (T j in result)
                {
                    Console.Write(j + " ");
                }
            }
        }
    }