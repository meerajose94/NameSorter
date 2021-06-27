# NameSorter
This program provides a sorted list of names from a file contains a list of names. The result has been displayed to console and writes to a file sorted-names-list.txt in
current working directory. 
Following points has been validating for names in file ::
  * Sorting is done based on last name and then by first name.
  * Name can have upto 3 given names. If any have more than 3 given names, it will not be considered for sorting.
  * Name should contain one lastname(if it provides a single name, it consider as given name)
  * If any name contians characters other than alphabets, are ignored for sorting.
 Program handles the errors causes for file input ouput operations and user can get appropriate messages for name which is ignored for getting sorted.
 It also displays the validated list of names before and after sorting.
 
 ###NameSorter.cs :: main program
 ###UnsortedNames.cs :: for retriving list of names from file and validating and adds into person.
 ###SortedNames.cs :: For sorting the names based on last name then by given names.
 ###SortedResult.cs :: Displaying and writing the result sorted list into console and file respectivily.
 
  
