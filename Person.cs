using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Person
   {
    private string firstName;
    private string lastName;

    public Person(string firstName, string lastName)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
    }

    public string FirstName
    { 
      get { return this.firstName; } 
      set { this.firstName = value; } 
    }

    public string LastName
    { 
      get { return this.lastName; } 
      set { this.lastName = value; } 
    }
  }
}