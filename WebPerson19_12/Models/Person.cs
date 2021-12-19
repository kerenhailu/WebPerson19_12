using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPerson19_12.Models
{
    public class Person
    {
        //string name;
        //string lname;
        //int age;
        //string email;
        public string Name { get; set; }
        public int Age { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
      public Person(string name, string lname,int age, string email)
        {
            this.Name = name;
            this.Lname = lname; 
            this.Age = age;
            this.Email = email;
        }
    }
}