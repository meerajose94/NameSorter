using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NameSorterProgramAssessment
{
    class UnsortedNames
    {
        public static List<Person> getUnsortedList(string filename)
        {

            string[] nameList;
            string msg;
            Regex r = new Regex("^[a-zA-Z ]+$");
            ArrayList noLastName = new ArrayList();
            ArrayList invalidnoOfGivenNames = new ArrayList();
            ArrayList invalidNames = new ArrayList();
            nameList = File.ReadAllLines(filename); // reading names in files into an array
            var people = new List<Person> { }; // // Parsing each name into people
            for (int i = 0; i < nameList.Length; ++i)
            {
                var name = nameList[i].Trim(); //removing if there any whitespaces 
                // Split the string into first and last names at the last space character
                int lastSpace = name.LastIndexOf(' '); // Spliting names into last name and given names
                if (lastSpace < 1) // error handling for if any names without lastname
                {
                    noLastName.Add(nameList[i]);
                     continue;
                }
                var checkName = name.Substring(0, lastSpace);
                if ((checkName.Count(s => s == ' ')) >= 3) // checking for number of given names; should be only up to 3 
                {
                    invalidnoOfGivenNames.Add(nameList[i]);
                }
                else if (!r.IsMatch(name))
                {
                    invalidNames.Add(name);
                }
                else
                {
                    var givenNames = checkName;
                    var lastName = name.Substring(lastSpace + 1);
                    people.Add(new Person(givenNames, lastName));
                }
            }
            //printing appropriate message for if any names which are not considered for sorting
            if (noLastName.Count > 0)
            {
                msg = "``INFO :: Given below names has been found without lastname and will be ignored for sorting";
                ValidateNamesMessage.displayMessage(noLastName, msg);
               
            }
            if (invalidnoOfGivenNames.Count > 0)
            {
                msg = "``INFO :: Given name has been found for having more than 3 given names and will be ignored for sorting";
                ValidateNamesMessage.displayMessage(invalidnoOfGivenNames, msg);
            }
            if (invalidNames.Count > 0)
            { 
                msg = "``INFO :: Given name contians characters other than alphabets and will be ignored for sorting";
                ValidateNamesMessage.displayMessage(invalidNames, msg);
            }
            Console.WriteLine("The unsorted list of names are ::  ");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\n");
            return people;

        }
    } 
}  
