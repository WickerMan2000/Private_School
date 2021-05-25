using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class Summary
    {
        private string _message;

        public string message
        {
            get { return _message; }
            set { _message = value; }
        }

        private List<string> _subjects;

        public List<string> subjects
        {
            get { return _subjects; }
            set { _subjects = value; }
        }

        private bool _dateTime;

        public bool dateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        private bool _haveFloat;

        public bool haveFloat
        {
            get { return _haveFloat; }
            set { _haveFloat = value; }
        }

        private bool _haveTitle;

        public bool haveTitle
        {
            get { return _haveTitle; }
            set { _haveTitle = value; }
        }

        private bool _haveDescription;

        public bool haveDescription
        {
            get { return _haveDescription; }
            set { _haveDescription = value; }
        }
    }
}
