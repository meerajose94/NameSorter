using System;
using System.IO;
using System.Collections.Generic;

namespace NameSorterProgramAssessment
{
    /*
     * It writes the sorted list to a file sorted-names-list in the current directory and displays the same to console.
     */
    public class SortedResult
    {
        public static void displaySortedResult(List<Person> people)
        {
            try
            {
                // Write to sorted-names-list.txt in the working directory
                Console.WriteLine("The sorted list of names based on last name ::  ");
                using (System.IO.StreamWriter file = new StreamWriter("sorted-names-list.txt"))
                {
                    foreach (Person person in people)
                    {
                        file.WriteLine(person);
                        Console.WriteLine(person);
                    }
                }
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Error unable to write to the file.");
            }
        }
    }
}