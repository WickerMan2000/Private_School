using MyProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    class Assignment : Course
    {
        private string _title;
        private string _description;
        private DateTime _subdatetime;
        private float _oralmark;
        private float _totalmark;

        public new string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public DateTime SubDateTime
        {
            get { return this._subdatetime; }
            set { this._subdatetime = value; }
        }

        public float OralMark
        {
            get { return this._oralmark; }
            set { this._oralmark = value; }
        }

        public float TotalMark
        {
            get { return this._totalmark; }
            set { this._totalmark = value; }
        }

        public static void HelperMethod(int j)
        {
            Console.WriteLine($"\n{j + 1}\n{CommandPromptUtils.assignments[j].Title}\n{CommandPromptUtils.assignments[j].Description}" +
                    $"\n{CommandPromptUtils.assignments[j].SubDateTime}");
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
            return $"\nTitle: {_title} \nDescription: {_description} \nSubmission Date Time: {_subdatetime} " +
                $"\nOral Mark: {_oralmark} \nTotal Mark: {_totalmark}";
        }
    }
}
