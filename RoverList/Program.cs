﻿using System;
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

            myList.ListNodes();
            Console.ReadLine();

            // TODO:  Remove every 3rd word
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
