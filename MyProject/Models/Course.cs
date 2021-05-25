using MyProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    class Course: ICourse
    {
        private string _title;
        protected string _stream;
        protected string _type;
        private DateTime _start_date;
        private DateTime _end_date;

        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }


        public string Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public DateTime Start_Date
        {
            get { return this._start_date; }
            set { this._start_date = value; }
        }

        public DateTime End_Date
        {
            get { return this._end_date; }
            set { this._end_date = value; }
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
            return $"\nTitle: {_title} \nStream: {_stream} \nType: {_type} \nStart Date: {_start_date} \nEnd Date: {_end_date}";
        }
    }
}
