using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterProgramAssessment
{
    public class Person
    {
            public string givenNames { get; }
            public string lastName { get; }
            public Person(string givenNames, string lastName)
            {
                this.givenNames = givenNames;
                this.lastName = lastName;
            }
            public override string ToString() => $"{givenNames} {lastName}";

            public override bool Equals(Object obj)
            {
                // If both objects are not of type Person, return false
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                Person p = (Person)obj;

                return givenNames == p.givenNames && lastName == p.lastName;
            }

            public override int GetHashCode() => givenNames.GetHashCode() * 97 + lastName.GetHashCode();
        
    }
}
