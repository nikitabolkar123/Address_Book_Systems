using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;


namespace AddressBook
{
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { set; get; }
        public string address { set; get; }
        public int phone { set; get; }
        public string city { set; get; }
        public string state { set; get; }
        public string email { set; get; }
        public int zipcode { set; get; }

        public override string ToString()
        {
            return String.Format("First Name: {0}, Last Name {1}, Adress: {2}, phone: {3}, city: {4}, state: {5}, zipcode: {6}, email: {7}",
                                              firstName, lastName, address, phone, city, state, zipcode, email);
        }
    }
}