using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class UniqueNameDict
    {

        public Dictionary<string, AddressBook> addBookobj = new Dictionary<string, AddressBook>();
        public void NewAddressBook()
        {
            AddressBook newAddBook = new AddressBook();
            newAddBook.AddMultipleContact();

            Console.WriteLine("Please enter Name of the AddressBook:");
            string addName = Convert.ToString(Console.ReadLine());
            addBookobj.Add(addName.ToLower(), newAddBook);
        }
    }
}
