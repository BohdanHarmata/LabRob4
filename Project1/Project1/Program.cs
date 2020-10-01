using System;
using System.Diagnostics;
using System.Data;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 myPerson = new Person2(22, 44, 112);
            Person1 person = myPerson;
            person.Person();
            Person2 person2 = (Person2)person;
            person2.Out();
        }
    }
}
