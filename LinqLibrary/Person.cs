using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary;
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearsOfExperience { get; set; }


    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}
