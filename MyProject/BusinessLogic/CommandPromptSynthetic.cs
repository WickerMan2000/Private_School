using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class CommandPromptSynthetic
    {
        public static bool Choice = false;

        static CommandPromptSynthetic()
        {
            Choice = true;
        }

        public CommandPromptSynthetic()
        {
            ToolBox.AddData(out List<Course> coursesyntheticdata, out List<Trainer> trainersyntheticdata,
            out List<Assignment> assignmentsyntheticdata, out List<Student> studentsyntheticdata);

            CommandPromptUtils.courses = coursesyntheticdata;
            CommandPromptUtils.trainers = trainersyntheticdata;
            CommandPromptUtils.assignments = assignmentsyntheticdata;
            CommandPromptUtils.students = studentsyntheticdata;

            bool decision = false;

            while (true)
            {
                if (decision)
                {
                    break;
                }

                foreach (var item in ToolBox.syntheticmenu)
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
                            Console.WriteLine("Give me the list of the courses please");
                            MultipleDetails<Course>.Iteration(CommandPromptUtils.courses);
                            ToolBox.CheckInputValidity();
                            break;
                        case 2:
                            Console.WriteLine("Give me the list of the trainers please");
                            MultipleDetails<Trainer>.Iteration(CommandPromptUtils.trainers);
                            ToolBox.CheckInputValidity();
                            break;
                        case 3:
                            Console.WriteLine("Give me the list of the students please");
                            MultipleDetails<Student>.Iteration(CommandPromptUtils.students);
                            ToolBox.CheckInputValidity();
                            break;
                        case 4:
                            Console.WriteLine("Give me the list of the assignments please");
                            MultipleDetails<Assignment>.Iteration(CommandPromptUtils.assignments);
                            ToolBox.CheckInputValidity();
                            break;
                        case 5:
                            CommandPromptUtils.studentsPerCourses.AddRange(AdditionalMultipleDetails<StudentsPerCourse, Student>.GetAdditionalMultipleDetails(CommandPromptUtils.students,
                            AdditionalMultipleDetails<StudentsPerCourse, Student>.MyMethod<StudentsPerCourse, Student>, Student.HelperMethod, "student"));
                            ToolBox.CheckInputValidity();
                            break;
                        case 6:
                            CommandPromptUtils.trainersPerCourses.AddRange(AdditionalMultipleDetails<TrainersPerCourse, Trainer>.GetAdditionalMultipleDetails(CommandPromptUtils.trainers,
                            AdditionalMultipleDetails<TrainersPerCourse, Trainer>.MyMethod<TrainersPerCourse, Trainer>, Trainer.HelperMethod, "trainer"));
                            ToolBox.CheckInputValidity();
                            break;
                        case 7:
                            CommandPromptUtils.assignmentsPerCourses.AddRange(AdditionalMultipleDetails<AssignmentsPerCourse, Assignment>.GetAdditionalMultipleDetails(CommandPromptUtils.assignments,
                            AdditionalMultipleDetails<AssignmentsPerCourse, Assignment>.MyMethod<AssignmentsPerCourse, Assignment>, Assignment.HelperMethod, "assignment"));
                            ToolBox.CheckInputValidity();
                            break;
                        case 8:
                            Console.WriteLine("Give me the list of the studentspercourse please");
                            AdditionalMultipleDetails<StudentsPerCourse, Student>.Iteration(CommandPromptUtils.studentsPerCourses);
                            ToolBox.CheckInputValidity();
                            break;
                        case 9:
                            Console.WriteLine("Give me the list of the trainerspercourse please");
                            AdditionalMultipleDetails<TrainersPerCourse, Trainer>.Iteration(CommandPromptUtils.trainersPerCourses);
                            ToolBox.CheckInputValidity();
                            break;
                        case 10:
                            Console.WriteLine("Give me the list of the assignmentspercourse please");
                            AdditionalMultipleDetails<AssignmentsPerCourse, Assignment>.Iteration(CommandPromptUtils.assignmentsPerCourses);
                            ToolBox.CheckInputValidity();
                            break;
                        case 11:
                            Console.WriteLine("Give me the list of the assignments per course per student please");
                            AssignmentsPerStudent assignmentsPerStudent = new AssignmentsPerStudent(CommandPromptUtils.studentsPerCourses,
                                CommandPromptUtils.assignmentsPerCourses);
                            break;
                        case 12:
                            decision = true;
                            Console.WriteLine("Goodbye and thank you very much.");
                            break;
                        default:
                            Console.WriteLine("The particular number does not belong to the menu");
                            break;
                    }
                }
                Console.Clear();
            }
        }
    }
}
