using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            RoverList myList = new RoverList();
            myList.Add("apple");
            myList.Add("bottom");
            myList.Add("jeans");
            myList.Add("boots");
            myList.Add("with");
            myList.Add("the");
            myList.Add("fur");
            myList.Add("she");
            myList.Add("hit");
            myList.Add("floor");
            myList.Add("next");
            myList.Add("thing");
            myList.Add("you");
            myList.Add("know");
            myList.Add("shawty");
            myList.Add("low");

            // TODO:  Print out the list
            Console.WriteLine("All items:");
            myList.ListNodes();

            // TODO:  Remove every 3rd word
            // TODO:  Print out the list
            int count = myList.Count;
            for (int i = 2; i < count; i += 2)
            {
                myList.RemoveAt(i);
            }
            Console.WriteLine("Every third node removed:");
            myList.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list
            while (true)
            {
                Console.Write("Enter words to be added to the end of the list (type 'done' when finished): ");
                String input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                else
                {
                    myList.Add(input);
                }
            }
            Console.WriteLine("Words added to the end of the list: ");
            myList.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list
            while (true)
            {
                Console.Write("Enter words to be added to the beginning of the list (type 'done' when finished): ");
                String input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                else
                {
                    myList.Add(0, input);
                }
            }
            Console.WriteLine("Words added to the beginning of the list: ");
            myList.ListNodes();

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList.ElementAt(i).Data.ToString().Length % 2 == 1)
                {
                    myList.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine("Every odd length word removed:");
            myList.ListNodes();

            // TODO:  Clear the list
            // TODO:  Print out the list
            myList.Clear();
            Console.WriteLine("List cleared: ");
            myList.ListNodes();

            Console.ReadLine();
        }
    }
}
