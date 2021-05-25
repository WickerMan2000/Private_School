using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class CommandPromptUtils
    {
        public static List<Course> courses = new List<Course>();
        public static List<Student> students = new List<Student>();
        public static List<Assignment> assignments = new List<Assignment>();
        public static List<Trainer> trainers = new List<Trainer>();
        public static List<AssignmentsPerCourse> assignmentsPerCourses = new List<AssignmentsPerCourse>();
        public static List<StudentsPerCourse> studentsPerCourses = new List<StudentsPerCourse>();
        public static List<TrainersPerCourse> trainersPerCourses = new List<TrainersPerCourse>();

        static CommandPromptUtils()
        {
            Console.WriteLine("If you want to input data press yes. Otherwise, if you want to work with synthetic data press no.");
            string choosedata = Console.ReadLine();
            if (ToolBox.Choice(choosedata) == "yes")
            {
                CommandPromptSynthetic.Choice = false;

                bool decision = false;

                while (true)
                {
                    if (decision)
                    {
                        break;
                    }

                    foreach (var item in ToolBox.menu)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("If you want to stop press yes. Otherwise if you want to continue press no.");
                    string mychoice = Console.ReadLine();
                    if (ToolBox.Choice(mychoice) == "yes")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Alright then. Choose a number to continue");

                        ToolBox.CkeckAnInput(out int myinput);

                        switch (myinput)
                        {
                            case 1:
                                Console.WriteLine("Give me the courses please");
                                courses.AddRange(MultipleDetails<Course>.GetMultipleDetails(ToolBox.GetCourseDetails));
                                ToolBox.CheckInputValidity();
                                break;
                            case 2:
                                Console.WriteLine("Give me the trainers please");
                                trainers.AddRange(MultipleDetails<Trainer>.GetMultipleDetails(ToolBox.GetTrainerDetails));
                                ToolBox.CheckInputValidity();
                                break;
                            case 3:
                                Console.WriteLine("Give me the students please");
                                students.AddRange(MultipleDetails<Student>.GetMultipleDetails(ToolBox.GetStudentDetails));
                                ToolBox.CheckInputValidity();
                                break;
                            case 4:
                                Console.WriteLine("Give me the assignments please");
                                assignments.AddRange(MultipleDetails<Assignment>.GetMultipleDetails(ToolBox.GetAssignmentDetails));
                                ToolBox.CheckInputValidity();
                                break;
                            case 5:
                                if (students.Count == 0)
                                {
                                    Console.WriteLine("Empty case!! You have to fill in the students list first.");
                                    goto case 3;
                                }
                                if (courses.Count == 0)
                                {
                                    Console.WriteLine("Empty case!! You have to fill in the courses list first.");
                                    goto case 1;
                                }
                                studentsPerCourses.AddRange(AdditionalMultipleDetails<StudentsPerCourse, Student>.GetAdditionalMultipleDetails(students,
                                AdditionalMultipleDetails<StudentsPerCourse, Student>.MyMethod<StudentsPerCourse, Student>, Student.HelperMethod, "student"));
                                ToolBox.CheckInputValidity();
                                break;
                            case 6:
                                if (trainers.Count == 0)
                                {
                                    Console.WriteLine("Empty case!! You have to fill in the trainers list first.");
                                    goto case 2;
                                }
                                if (courses.Count == 0)
                                {
                                    Console.WriteLine("Empty case!! You have to fill in the courses list first.");
                                    goto case 1;
                                }
                                trainersPerCourses.AddRange(AdditionalMultipleDetails<TrainersPerCourse, Trainer>.GetAdditionalMultipleDetails(trainers,
                                AdditionalMultipleDetails<TrainersPerCourse, Trainer>.MyMethod<TrainersPerCourse, Trainer>, Trainer.HelperMethod, "trainer"));
                                ToolBox.CheckInputValidity();
                                break;
                            case 7:
                                if (assignments.Count == 0)
                                {
                                    Console.WriteLine("Empty case!! You have to fill in the assignments list first.");
                                    goto case 4;
                                }
                                if (courses.Count == 0)
                                {
                                    Console.WriteLine("Empty case!! You have to fill in the courses list first.");
                                    goto case 1;
                                }
                                assignmentsPerCourses.AddRange(AdditionalMultipleDetails<AssignmentsPerCourse, Assignment>.GetAdditionalMultipleDetails(assignments,
                                AdditionalMultipleDetails<AssignmentsPerCourse, Assignment>.MyMethod<AssignmentsPerCourse, Assignment>, Assignment.HelperMethod, "assignment"));
                                ToolBox.CheckInputValidity();
                                break;
                            case 9:
                                decision = true;
                                break;
                            default:
                                Console.WriteLine("The particular number does not belong to the menu");
                                break;
                        }
                    }
                    Console.Clear();
                }
            }
            else
            {
                CommandPromptSynthetic commandPromptSynthetic = new CommandPromptSynthetic();
            }
        }
    }
}
