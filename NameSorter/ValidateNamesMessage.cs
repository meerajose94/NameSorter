using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NameSorterProgramAssessment
{
    class ValidateNamesMessage
    {
        //printing appropriate message for if any names which are not considered for sorting
        public static void displayMessage(ArrayList arr, string message)

        {
            Console.WriteLine(message);
            foreach (string str in arr)
            {

                Console.WriteLine(str);
            }
            Console.WriteLine("\n");
        }
    }
}
