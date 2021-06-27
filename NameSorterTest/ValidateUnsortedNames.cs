using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterProgramAssessment;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NameSorterTest
{
    //This includes all the possible testcases for the UnsorterNames program
    [TestClass] 
    public class ValidateUnsortedNames
    {
        /* test to check whether UnsorterNames pgm can read all names from file 
         * and assign to array list and get ready for sorting.
         * and it should remove all single names and names having more than 3 given names
         * and names contains other characters than alphabets and remove the whitespace after name if any.
         * Inputfile :: UnsortedList.txt(under InputTestData
         * folder) contains all such possible names.
        */
        [TestMethod]
        public void Validate_GetUnsortedListFromFile()
        {
            var givenNames = new List<String> {
                "Cate",
                "Russell",
                "Oliver Amelia",
                "Toni",
                "Graham",
                "Adam John",
                "Peter Pierre",
                "John Paul Peter",
            };
            var lastName = new List<String> {
                "Blanchett",
                "Crowe",
                "Charlotte",
                "Collette",
                "Kennedy",
                "Isaac",
                "George",
                "Mathew",
            };

            var people = new List<Person> { };
            for (int i = 0; i < givenNames.Count; ++i)
            {
                people.Add(new Person(givenNames[i], lastName[i]));

            }

            string filename = @"C:\Users\munnu\source\repos\NameSorter\NameSorterTest\InputTestData\UnsortedList.txt";
            var testResult = UnsortedNames.getUnsortedList(filename);
            CollectionAssert.AreEqual(testResult, people);
        }

        
    }
}