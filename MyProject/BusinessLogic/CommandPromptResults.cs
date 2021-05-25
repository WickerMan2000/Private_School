using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class CommandPromptResults
    {
        CommandPromptUtils cpUtils = new CommandPromptUtils();

        public CommandPromptResults() 
        {
            bool decision = false;

            while (true)
            {
                if (CommandPromptSynthetic.Choice)
                {
                    break;
                }

                if (decision)
                {
                    break;
                }

                foreach (var item in ToolBox.resultmenu)
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
                            Console.WriteLine("Give me the list of the studentspercourse please");
                            AdditionalMultipleDetails<StudentsPerCourse, Student>.Iteration(CommandPromptUtils.studentsPerCourses);
                            ToolBox.CheckInputValidity();
                            break;
                        case 6:
                            Console.WriteLine("Give me the list of the trainerspercourse please");
                            AdditionalMultipleDetails<TrainersPerCourse, Trainer>.Iteration(CommandPromptUtils.trainersPerCourses);
                            ToolBox.CheckInputValidity();
                            break;
                        case 7:
                            Console.WriteLine("Give me the list of the assignmentspercourse please");
                            AdditionalMultipleDetails<AssignmentsPerCourse, Assignment>.Iteration(CommandPromptUtils.assignmentsPerCourses);
                            ToolBox.CheckInputValidity();
                            break;
                        case 8: 
                            Console.WriteLine("Give me the list of the assignments per course per student please");
                            AssignmentsPerStudent assignmentsPerStudent = new AssignmentsPerStudent(CommandPromptUtils.studentsPerCourses,
                                CommandPromptUtils.assignmentsPerCourses);
                            break;
                        case 9:
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
