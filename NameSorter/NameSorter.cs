using System;
using System.Linq;
using System.Text;
using System.IO;

namespace NameSorterProgramAssessment
{
    class NameSorter
    {
        static void Main(string[] args)
        {
            /* NameSorter program creates a sorted list of names, first sorted by last-name and then by given-names.
             * It will takes a unsorted file as input and file name which is in the current directory passed as argument through command line and provides
             * a sorted-names.txt file in working directory and displays the same result in console. 
             * 
             */

            if (args.Length != 1) // checking for only one argument for filename 
            {
                Console.WriteLine(" Sorry! You have entered wrong number of arguments \n Program has been terminated");
                return;
            }

            string filename = args[0];
            string errormsg = "File name is incorrect or File does not exist in the current directory";
            try // error handling for incorrect file name in the current working directory
            {
                if (!File.Exists(filename))
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(errormsg);
                return;
            }
            var unsorted_list = UnsortedNames.getUnsortedList(filename);
            var sorted = SortedNames.getSortedList(unsorted_list);
            SortedResult.displaySortedResult(sorted);

        }
    }
}