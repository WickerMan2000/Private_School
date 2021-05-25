using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class ToolBox
    {
        public static List<string> menu = new List<string>() { "Press 1 to insert one or more courses",
                                                                "Press 2 to insert one or more trainers",
                                                                "Press 3 to insert one or more students",
                                                                "Press 4 to insert one or more assignments",
                                                                "Press 5 to insert an existing student to one or more courses",
                                                                "Press 6 to insert an existing trainer to one or more courses",
                                                                "Press 7 to insert an existing assignment to one or more courses",
                                                                "Press 8 to modify the marks of one or more assignments for a student",
                                                                "Press 9 to stop data insertion and move to the next menu"};

        public static List<string> resultmenu = new List<string>() {"Press 1 to get the list of all courses",
                                                                   "Press 2 to get the list of all trainers",
                                                                   "Press 3 to get the list of all students",
                                                                   "Press 4 to get the list of all assignments",
                                                                   "Press 5 to get the list of all students per course",
                                                                   "Press 6 to get the list of all trainers per course",
                                                                   "Press 7 to get the list of all assignments per course",
                                                                   "Press 8 the list of the assignments per course per student please",
                                                                   "Press 9 to finish the whole process"};

        public static List<string> syntheticmenu = new List<string>() { "Press 1 to get the list of all courses",
                                                                        "Press 2 to get the list of all trainers",
                                                                        "Press 3 to get the list of all students",
                                                                        "Press 4 to get the list of all assignments",
                                                                        "Press 5 to insert an existing student to one or more courses",
                                                                        "Press 6 to insert an existing trainer to one or more courses",
                                                                        "Press 7 to insert an existing assignment to one or more courses",
                                                                        "Press 8 to get the list of all students per course",
                                                                        "Press 9 to get the list of all trainers per course",
                                                                        "Press 10 to get the list of all assignments per course",
                                                                        "Press 11 the list of the assignments per course per student please",
                                                                        "Press 12 to finish the whole process"};

        public static List<Course> syntheticcourse = new List<Course>();
        public static List<Trainer> synthetictrainer = new List<Trainer>();
        public static List<Student> syntheticstudent = new List<Student>();
        public static List<Assignment> syntheticassignment = new List<Assignment>();
        
        public static void AddData(out List<Course> coursesyntheticdata, out List<Trainer> trainersyntheticdata, 
            out List<Assignment> assignmentsyntheticdata, out List<Student> studentsyntheticdata)
        {

            Course course1 = new Course { Title = "CB10", Stream = "C#",         Type = "Full-Time", Start_Date = new DateTime(2020, 10, 10), End_Date = new DateTime(2021, 01, 28) };
            Course course2 = new Course { Title = "CB11", Stream = "Java",       Type = "Full-Time", Start_Date = new DateTime(2020, 10, 10), End_Date = new DateTime(2021, 01, 28) };
            Course course3 = new Course { Title = "CB12", Stream = "JavaScript", Type = "Full-Time", Start_Date = new DateTime(2020, 10, 10), End_Date = new DateTime(2021, 01, 28) };
            Course course4 = new Course { Title = "CB20", Stream = "C#",         Type = "Part-Time", Start_Date = new DateTime(2020, 10, 10), End_Date = new DateTime(2021, 04, 28) };
            Course course5 = new Course { Title = "CB21", Stream = "Java",       Type = "Part-Time", Start_Date = new DateTime(2020, 10, 10), End_Date = new DateTime(2021, 04, 28) };
            Course course6 = new Course { Title = "CB22", Stream = "JavaScript", Type = "Part-Time", Start_Date = new DateTime(2020, 10, 10), End_Date = new DateTime(2021, 04, 28) };
            syntheticcourse.Add(course1);
            syntheticcourse.Add(course2);
            syntheticcourse.Add(course3);
            syntheticcourse.Add(course4);
            syntheticcourse.Add(course5);
            syntheticcourse.Add(course6);

            Trainer trainer1 = new Trainer { FirstName = "Christos", LastName = "Staurou", Subject = "C#" };
            Trainer trainer2 = new Trainer { FirstName = "Nikos",    LastName = "Nikou",   Subject = "Java" };
            Trainer trainer3 = new Trainer { FirstName = "Georgia",  LastName = "Pavlou",  Subject = "JavaScript" };
            Trainer trainer4 = new Trainer { FirstName = "Gianna",   LastName = "Manesi",  Subject = "Python" };
            synthetictrainer.Add(trainer1);
            synthetictrainer.Add(trainer2);
            synthetictrainer.Add(trainer3);
            synthetictrainer.Add(trainer4);

            Student student1 = new Student { FirstName = "Giannis", LastName = "Maniatis",    DateOfBirth = new DateTime(1990, 06, 12), TuitionFees = 2500 };
            Student student2 = new Student { FirstName = "Giwrgos", LastName = "Stavrou",     DateOfBirth = new DateTime(1991, 10, 07), TuitionFees = 2500 };
            Student student3 = new Student { FirstName = "Anthi",   LastName = "Nickolaidou", DateOfBirth = new DateTime(1988, 08, 10), TuitionFees = 2500 };
            Student student4 = new Student { FirstName = "Anna",    LastName = "Vlachou",     DateOfBirth = new DateTime(1994, 10, 02), TuitionFees = 2500 };
            Student student5 = new Student { FirstName = "Dimitra", LastName = "Christou",    DateOfBirth = new DateTime(1992, 03, 04), TuitionFees = 2500 };
            Student student6 = new Student { FirstName = "Spiros",  LastName = "Grigoriou",   DateOfBirth = new DateTime(1987, 07, 07), TuitionFees = 2500 };
            syntheticstudent.Add(student1);
            syntheticstudent.Add(student2);
            syntheticstudent.Add(student3);
            syntheticstudent.Add(student4);
            syntheticstudent.Add(student5);
            syntheticstudent.Add(student6);

            Assignment assignment1 = new Assignment { Title = "Individual Project Part A FT", Description = "Part A Private Scool", SubDateTime = new DateTime(2020, 11, 11), OralMark = 20, TotalMark = 100 };
            Assignment assignment2 = new Assignment { Title = "Individual Project Part B FT", Description = "Part B Private Scool", SubDateTime = new DateTime(2020, 12, 11), OralMark = 20, TotalMark = 100 };
            Assignment assignment3 = new Assignment { Title = "Group Project Part A FT",      Description = "Final E-shop",         SubDateTime = new DateTime(2021, 01, 22), OralMark = 20, TotalMark = 100 };
            Assignment assignment4 = new Assignment { Title = "Individual Project Part A PT", Description = "Part A Private Scool", SubDateTime = new DateTime(2020, 12, 11), OralMark = 20, TotalMark = 100 };
            Assignment assignment5 = new Assignment { Title = "Individual Project Part B PT", Description = "Part B Private Scool", SubDateTime = new DateTime(2021, 01, 15), OralMark = 20, TotalMark = 100 };
            Assignment assignment6 = new Assignment { Title = "Group Project Part A PT",      Description = "Final E-shop",         SubDateTime = new DateTime(2021, 04, 11), OralMark = 20, TotalMark = 100 };
            syntheticassignment.Add(assignment1);
            syntheticassignment.Add(assignment2);
            syntheticassignment.Add(assignment3);
            syntheticassignment.Add(assignment4);
            syntheticassignment.Add(assignment5);
            syntheticassignment.Add(assignment6);

            coursesyntheticdata = syntheticcourse;
            trainersyntheticdata = synthetictrainer;
            studentsyntheticdata = syntheticstudent;
            assignmentsyntheticdata = syntheticassignment;
        }

        public static Trainer GetTrainerDetails(List<string> subjects = null)
        {
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "JavaScript", "Python", "PHP" };
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail
                (new Summary { message = "Give me your first name" });
            trainer.LastName = AskDetail
                (new Summary { message = "Give me your last name" });
            trainer.Subject = AskDetail
                (new Summary { message = "Give me the subject you teach", subjects = subjects });
            return trainer;
        }

        public static Course GetCourseDetails(List<string> subjects = null)
        {
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "JavaScript", "Python", "PHP" };
            List<string> types = new List<string>() { "Full-Time", "Part-Time" };
            Course course = new Course();
            course.Start_Date = DateTime.Parse(AskDetail
                (new Summary { message = "Give me your start date. The dateformat must be dd-MM-yyyy", dateTime = true }));
            course.End_Date = DateTime.Parse(AskDetail
                (new Summary { message = "Give me your end date. The dateformat must be dd-MM-yyyy", dateTime = true }));
            course.Stream = AskDetail
                (new Summary { message = "Give me your Stream", subjects = subjects });
            course.Title = AskDetail
                (new Summary { message = "Give me your Title", haveTitle = true });
            course.Type = AskDetail
                (new Summary { message = "Give me your Type", subjects = types });
            return course;
        }

       
        public static Assignment GetAssignmentDetails(List<string> subjects = null)
        {
            Assignment assignment = new Assignment();
            assignment.Title = AskDetail
                (new Summary { message = "Give me the title please" });
            assignment.Description = AskDetail
                (new Summary { message = "Give me the description please", haveDescription = true });
            var mydatetime = DateTime.Parse(AskDetail
                (new Summary { message = "Give me the Submission datetime please. The dateformat must be dd-MM-yyyy", dateTime = true }));
            while (true)
            {
                if (mydatetime.DayOfWeek == DayOfWeek.Saturday || mydatetime.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("There could not be submissions on Saturday and Sunday. Try again please.");
                    mydatetime = DateTime.Parse(AskDetail
                        (new Summary { message = "Give me the Submission datetime please. The dateformat must be dd-MM-yyyy", dateTime = true }));
                }
                else
                {
                    assignment.SubDateTime = mydatetime;
                    break;
                }
            }
            assignment.OralMark = float.Parse(AskDetail
                (new Summary { message = "Give me your oral mark", haveFloat = true }));
            assignment.TotalMark = float.Parse(AskDetail
                (new Summary { message = "Give me your total mark", haveFloat = true }));
            return assignment;
        }
               
        public static Student GetStudentDetails(List<string> subjects = null)
        {
            Student student = new Student();
            student.DateOfBirth = DateTime.Parse(AskDetail
                (new Summary { message = "Give me your date of birth. The dateformat must be dd-MM-yyyy", dateTime = true }));
            student.FirstName = AskDetail
                (new Summary { message = "Give me your first name please" });
            student.LastName = AskDetail
                (new Summary { message = "Give me your last name please" });
            student.TuitionFees = float.Parse(AskDetail
                (new Summary { message = "Give me the tuition fees please", haveFloat = true }));
            return student;
        }
                     
        private static string SelectFromListOfStrings(List<string> elements)
        {
            string result = string.Empty;
            int counter = 1;
            foreach (var item in elements)
            {
                Console.WriteLine($"\n{counter++}. {item}");
            }
            string number = Console.ReadLine();
            while (true)
            {
                if (Int32.TryParse(number, out int choice))
                {
                    if (choice == 0 || choice > elements.Count) { Console.WriteLine("Wrong choice! Please try again"); number = Console.ReadLine(); }
                    else { result = elements.ElementAt(choice - 1); break; }
                }
                else
                {
                    Console.WriteLine("Try again please. Give an integer.");
                    number = Console.ReadLine();
                }
            }
            return result;
        }

        public static void CkeckAnInput(out int finalinput)
        {
            string input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out int newinput))
                {
                    finalinput = newinput;
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
        }

        public static void CheckInputValidity()
        {
            Console.WriteLine("Press Enter to Continue");
            string press = Console.ReadLine();
            while (true)
            {
                if (press.Equals(string.Empty))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong. Try again by pressing Enter.");
                    press = Console.ReadLine();
                }
            }
        }

        public static string DealWithDateTime()
        {
            string result;
            while (true)
            {
                string datetime = Console.ReadLine();
                if (datetime.Equals(string.Empty)) return default(DateTime).ToString();
                else
                {
                    if (DateTime.TryParseExact(datetime, "dd-MM-yyyy", null,
                           DateTimeStyles.None, out DateTime parsedDate)) { result = parsedDate.ToString(); break; }
                    else Console.WriteLine("Try again");
                }
            }
            return result;
        }

        private static string MyFloat()
        {
            string floatNumber = Console.ReadLine();
            if (floatNumber.Equals(string.Empty)) return default(float).ToString();
            else
            {
                while (true)
                {
                    if (float.TryParse(floatNumber, out float choice))
                    {
                        return choice.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        floatNumber = Console.ReadLine();
                    }
                }
            }
        }

        public static string Stability()
        {
            string number = Console.ReadLine();
            while (true)
            {
                if (Int32.TryParse(number, out int choice))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Try again please. Give an integer.");
                    number = Console.ReadLine();
                }
            }
        }

        private static string AskDetail(Summary summary)
        {
            string result;
            Console.Write(summary.message + " : ");
            if (summary.haveTitle) { result = "CB" + Stability(); return result; }
            if (summary.haveDescription) { result = Console.ReadLine(); return result; }
            if (summary.subjects != null) result = SelectFromListOfStrings(summary.subjects);
            else if (summary.haveFloat) return MyFloat();
            else
            {
                if (summary.dateTime) return DealWithDateTime();
                else
                {
                    string choice = Console.ReadLine();
                    bool check = choice.Equals(string.Empty);
                    if (check) result = "XXXXXX";
                    else result = choice;
                }
            }
            return result;
        }
        public static string Choice(string command)
        {
            while (command != "yes" && command != "no")
            {
                Console.WriteLine("Try again");
                command = Console.ReadLine();
                if (command == "yes" || command == "no")
                    break;
                else
                    continue;
            }
            return command;
        }

        public static void CheckForTheDoubles<T>(List<T> mylist, out List<T> checkedlist) 
        {
            List<T> mynewlist = new List<T>();

            for (int i = 0; i < mylist.Count - 1; i++) 
            {
                for (int j = i + 1; j < mylist.Count; j++) 
                {
                    if(Comparison<T>(mylist[i], mylist[j]))
                    {
                        mynewlist.Add(mylist[i]);
                    }
                }
            }
            var secondlist = mylist.Except(mynewlist);

            checkedlist = secondlist.ToList(); 
        }

        public static bool Comparison<T>(T Object1, T Object2)
        {
            Type type = typeof(T);

            if (Object1 == null || Object2 == null)
                return false;

            foreach (var property in type.GetProperties())
            {
                string Object1Value = string.Empty;
                string Object2Value = string.Empty;
                if (type.GetProperty(property.Name).GetValue(Object1, null) != null)
                    Object1Value = type.GetProperty(property.Name).GetValue(Object1, null).ToString();
                if (type.GetProperty(property.Name).GetValue(Object2, null) != null)
                    Object2Value = type.GetProperty(property.Name).GetValue(Object2, null).ToString();
                if (Object1Value.Trim() != Object2Value.Trim())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
