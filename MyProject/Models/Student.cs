using MyProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    class Student : Course
    {
        private string _firstname;
        private string _lastname;
        private DateTime _dateofbirth;
        private double _tuitionfees;

        public string FirstName
        {
            get { return this._firstname; }
            set { this._firstname = value; }
        }
        public string LastName
        {
            get { return this._lastname; }
            set { this._lastname = value; }
        }
        public DateTime DateOfBirth
        {
            get { return this._dateofbirth; }
            set { this._dateofbirth = value; }
        }

        public double TuitionFees
        {
            get { return this._tuitionfees; }
            set { this._tuitionfees = value; }
        }

        public static void HelperMethod(int j)
        {
            Console.WriteLine($"\n{j + 1}\n{CommandPromptUtils.students[j].FirstName}\n{CommandPromptUtils.students[j].LastName}" +
                $"\n{CommandPromptUtils.students[j].DateOfBirth}\n{CommandPromptUtils.students[j].TuitionFees}");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"\nFirst Name: {_firstname} \nLast Name: {_lastname} " +
                $"\nDate of Birth: {_dateofbirth} \nTuitionFees: {_tuitionfees}";
        }
    }
}
