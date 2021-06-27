using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NameSorterProgramAssessment
{
    class SortedNames
    {
        //return a sorted list based on last name then by given names
        public static List<Person> getSortedList(List<Person> unsorted_List)
        {
            return unsorted_List.OrderBy(person => person.lastName)
                                 .ThenBy(person => person.givenNames)
                                 .ToList();
        }
    }
}
