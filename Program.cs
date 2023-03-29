using GenericDemo;

namespace GenericConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generic Concepts Problems");
            Console.WriteLine("Select any one option \n1.Delete Integer,double,character element from array.\n2.Generic Method to Delete Integer,double,character element from array.");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int[] intArry = DeleteArrayElement.GetIntElement();
                    Console.WriteLine("Plese pick up any one element");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    DeleteArrayElement.DeleteIntElement(intArry, delete);
                    
                    double[] doubleArry = DeleteArrayElement.GetDoubleElement();
                    Console.WriteLine("Plese pick up any one element");
                    double doubleDelete = Convert.ToDouble(Console.ReadLine());
                    DeleteArrayElement.DeleteDoubleElement(doubleArry, doubleDelete);
                  
                    char[] charArry = DeleteArrayElement.GetCharElement();
                    Console.WriteLine("Plese pick up any one element");
                    char charDelete = Convert.ToChar(Console.ReadLine());
                    DeleteArrayElement.DeleteCharElement(charArry, charDelete);
                    break;
                case 2:
                    int[] intArryG = DeleteArrayElement.GetIntElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    int deleteG = Convert.ToInt32(Console.ReadLine());
                    GenericMethod.DeleteElementFromArray<int>(intArryG, deleteG);
                 
                    double[] doubleArryG = DeleteArrayElement.GetDoubleElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    double doubleDeleteG = Convert.ToDouble(Console.ReadLine());
                    GenericMethod.DeleteElementFromArray<double>(doubleArryG, doubleDeleteG);
                    
                    char[] charArryG = DeleteArrayElement.GetCharElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    char charDeleteG = Convert.ToChar(Console.ReadLine());
                    GenericMethod.DeleteElementFromArray<char>(charArryG, charDeleteG);
                    break;

                default:
                    Console.WriteLine("Please Enter Right Option number From given List");
                    break;
            }
        }
    }
}
