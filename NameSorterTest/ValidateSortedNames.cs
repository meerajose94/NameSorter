using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterProgramAssessment;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NameSorterTest
{
    //This includes all the possible testcases for the UnsorterNames program
    [TestClass]
    public class ValidatesortedNames
    {
        /* test to check whether the SortedNames pgm can sort the list of names based on last name and 
         * then by given names.
        */
        [TestMethod]
        public void Validate_GetsortedListFromUnsortedNames()
        {
            var givenNames = new List<String> {
                "Cate",
                "Oliver Amelia",
                "Toni",
                "Russell",
                "Peter Pierre",
                "Adam John",
                "Graham",
                "John Paul Peter",
            };
            var lastName = new List<String> {
                "Blanchett",
                "Charlotte",
                "Collette",
                "Crowe",
                "George",
                "Isaac",
                "Kennedy",
                "Mathew",
            };

            var people = new List<Person> { };
            for (int i = 0; i < givenNames.Count; ++i)
            {
                people.Add(new Person(givenNames[i], lastName[i]));

            }
            var filename = @"C:\Users\munnu\source\repos\NameSorter\NameSorterTest\InputTestData\UnsortedList.txt";
            var unsorted = UnsortedNames.getUnsortedList(filename);
            var testdata = SortedNames.getSortedList(unsorted);
            CollectionAssert.AreEqual(testdata, people);
        }


    }
}