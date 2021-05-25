﻿using MyProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    class Trainer 
    {
        private string _firstname;
        private string _lastname;
        private string _subject;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value; }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value; }
        }

        public string Subject
        {
            get { return (this._subject); }
            set { this._subject = value; }
        }

        public static void HelperMethod(int j)
        {
            Console.WriteLine($"\n{j + 1}\n{CommandPromptUtils.trainers[j].FirstName}\n{CommandPromptUtils.trainers[j].LastName}" +
                $"\n{CommandPromptUtils.trainers[j].Subject}"); 
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
            return ($"\nFirst Name: {_firstname} \nLast Name: {_lastname} " +
                $"\nSubject: {_subject}");
        }
    }
}
