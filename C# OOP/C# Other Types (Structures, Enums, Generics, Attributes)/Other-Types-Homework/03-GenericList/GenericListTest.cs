
namespace _03_GenericList
{
    using System;

    class GenericListTest
    {
        static void Main(string[] args)
        {
            Type type = typeof(GenericList<>);
            object[] versionAttribute = type.GetCustomAttributes(typeof(Version), true);
            foreach (Version attribute in versionAttribute)
            {
                Console.WriteLine("Version: " + attribute.Major + "." + attribute.Minor);
            }

            //creating generic list
            GenericList<int> list = new GenericList<int>(1);

            Console.Write("List with 1 element: ");
            list.AddElement(1);
            Console.WriteLine(list);
           
            Console.Write("List with 2 elements: ");
            list.AddElement(2);
            Console.WriteLine(list);
           
            Console.Write("Insering the element 0: ");
            list.InsertElement(0, 0);
            Console.WriteLine(list);
          
            Console.Write("We add element 2 again: ");
            list.AddElement(2);
            Console.WriteLine(list);
          
            Console.Write("Minimal element: ");
            Console.WriteLine(list.Min());
           
            Console.Write("Max element: ");
            Console.WriteLine(list.Max());
            Console.WriteLine();

            //creating new generic string list
            GenericList<string> stringList = new GenericList<string>();
           
            Console.Write("Adding first element \"one\": ");
            stringList.AddElement("one");
            Console.WriteLine(stringList);
           
            Console.Write("Adding second element \"two\": ");
            stringList.AddElement("two");
            Console.WriteLine(stringList);
           
            Console.Write("The list contains \"one\" at position: ");
            Console.WriteLine(stringList.Cointains("one"));
          
            Console.WriteLine("The list contains \"two\" at position: ");
            Console.WriteLine(stringList.Cointains("two"));

            //clearing the generic list
            stringList.ClearList();
            Console.WriteLine(stringList);
        }
    }
}
