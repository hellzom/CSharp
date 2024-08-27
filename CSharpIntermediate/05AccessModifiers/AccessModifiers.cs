using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05AccessModifiers
{

    //Access Modifiers -> way to control access to a call and/or it's members.
    //1. Public
    //2. Private
    //3. Protected
    //4. Internal
    //5. Protcted Internal
    public class AccessModifiers
    {
        //Encapsulation -> Hiding vital data from outside
        //Define fields as private, and provide getter setter methods as public
        //Objects should hide their implementation detail and should only show what they can do.
    }

    public class Personn
    {
        private DateTime _birthDate; // use _ before private fields
        //this cannot be directly accessed from objects.


        //can only be acessed via the two methods
        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }
        public DateTime GetBirthDate()
        {
            return _birthDate; 
        }   

        //usage
        //var personn = new Personn();
        //personn.SetBirthDate(new DateTime(1988,1,1));
        //Console.WriteLine(personn.GetBirthDate());
    }

    public class NewPerson
    {
        //Property-> A property is a class member that encapsulates a getter/setter for accessing a field.
        //Helps in creating getter setter with less code.
        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        //without declearation compiler automatically creates a private field on runtime. can check with ilideas cmd command
        public DateTime JoiningDate { get; set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
