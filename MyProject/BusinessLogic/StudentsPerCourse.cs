using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class StudentsPerCourse : Student, ICourse, IUseful
    {
        private int _number1;

        public int Number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }

        private int _number2;

        public int Number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }

        public override string ToString()
        {
            return $"\nTitle: {CommandPromptUtils.courses[Number1 - 1].Title} \nStream: {CommandPromptUtils.courses[Number1 - 1].Stream} " +
                $"\nType: {CommandPromptUtils.courses[Number1 - 1].Type} \nStart Date: {CommandPromptUtils.courses[Number1 - 1].Start_Date} " +
                $"\nEnd Date: {CommandPromptUtils.courses[Number1 - 1].End_Date}\nFisrtName:{CommandPromptUtils.students[Number2 - 1].FirstName} \nLastName:{CommandPromptUtils.students[Number2 - 1].LastName}" +
                $"\nDateOfBirth:{CommandPromptUtils.students[Number2 - 1].DateOfBirth}\nTuitionFeees:{CommandPromptUtils.students[Number2 - 1].TuitionFees}";
        }
    }
}
