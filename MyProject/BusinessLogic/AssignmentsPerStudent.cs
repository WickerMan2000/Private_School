using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class AssignmentsPerStudent
    {
        public AssignmentsPerStudent(List<StudentsPerCourse> studentsPerCourses, List<AssignmentsPerCourse> assignmentsPerCourses)
        {
            Console.WriteLine("..............Now give me all the assignments per student..............");

            List<string> studentassignments = new List<string>();

            for (int i = 0; i < studentsPerCourses.Count; i++)
            {
                for (int j = 0; j < assignmentsPerCourses.Count; j++)
                {
                    if (studentsPerCourses[i].Title == assignmentsPerCourses[j].Title) 
                    {
                        studentassignments.Add(studentsPerCourses[i].FirstName + " "
                            + studentsPerCourses[i].LastName + " " + assignmentsPerCourses[j].Title + " " +
                            assignmentsPerCourses[j].Description
                            + " " + assignmentsPerCourses[j].Stream + " " + assignmentsPerCourses[j].Type);
                    }
                }
            }

            foreach (var item in studentassignments)
            {
                Console.WriteLine(item);
            }
        }
    }
}
