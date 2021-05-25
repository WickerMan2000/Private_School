using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class AdditionalMultipleDetails<U, T> where U : ICourse 
    {
        public delegate U GetAdditionalDetails(List<T> alist, string word, List<int[]> list, GetMyHelperMethod GetMyHelper);

        public delegate void GetMyHelperMethod(int i);

        public static List<U> GetAdditionalMultipleDetails(List<T> listforallcases, GetAdditionalDetails AdditionalDifferentDetails,
            GetMyHelperMethod GetMyHelper, string word)
        {
            List<U> mylist = new List<U>();

            List<int[]> checks = new List<int[]>();

            while (true)
            {
                Console.WriteLine("..............Now give me all the courses..............");

                for (int j = 0; j < CommandPromptUtils.courses.Count; j++)
                {
                    Console.WriteLine($"\n{j + 1}\n{CommandPromptUtils.courses[j].Title}\n{CommandPromptUtils.courses[j].Stream}" +
                        $"\n{CommandPromptUtils.courses[j].Type}");
                }

                mylist.Add(AdditionalDifferentDetails(listforallcases, word, checks, GetMyHelper));
                Console.WriteLine("If you want to stop press yes. Otherwise press no");
                string command = Console.ReadLine();
                if (ToolBox.Choice(command) == "yes") break;
                else continue;
            }
            Reordering(mylist, out List<U> finalsortedlist);
            return finalsortedlist;
        }

        public static U MyMethod<U, T>(List<T> listforallcases, string word, List<int[]> checks, 
            GetMyHelperMethod GetMyHelper) where U : IUseful, new()
        {
            Console.WriteLine("Press a number to choose a course please");
            string number1 = Console.ReadLine();
            MakeACheck(number1, CommandPromptUtils.courses, out string newnumber1);

            Console.WriteLine($"..............Now give me all the {word}s..............");

            for (int j = 0; j < listforallcases.Count; j++)
            {
                GetMyHelper(j);
            }

            Console.WriteLine($"Press a number to choose the {word} please");
            string number2 = Console.ReadLine();
            MakeACheck(number2, listforallcases, out string newnumber2);

            int[] anarray = { int.Parse(newnumber1), int.Parse(newnumber2) };
            checks.Add(anarray);
            CheckForTheSameChoice(int.Parse(newnumber1), int.Parse(newnumber2), checks, listforallcases, 
                word, out string thisisthenumber1, out string thisisthenumber2);

            U myobject = new U { Number1 = int.Parse(thisisthenumber1), Number2 = int.Parse(thisisthenumber2) };
            return myobject;
        }

        public static void Iteration(List<U> myList)
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }

        public static void MakeACheck<T>(string number, List<T> myList, out string newnumber)
        {
            while (true)
            {
                if (int.TryParse(number, out int firstNumber) & firstNumber > 0 & firstNumber <= myList.Count) 
                    break;
                else
                {
                    Console.WriteLine("Wrong. Please try again.");
                    number = Console.ReadLine();
                    continue;
                }
            }
            newnumber = number;
        }

        public static bool CheckForTheSameChoice<T>(int number1, int number2, List<int[]> checks, List<T> mylist,
            string word, out string thisisthenumber1, out string thisisthenumber2)
        {
            for (int i = 0; i < checks.Count - 1; i++) 
            {
                if (checks[i].SequenceEqual(checks[checks.Count - 1]))
                {
                    checks.Remove(checks[checks.Count - 1]);
                    Console.WriteLine("The particular pair already exists. Try a different pair please.");

                    Console.WriteLine("Press a number to choose a course please");
                    string tryanewnumber1 = Console.ReadLine();
                    MakeACheck(tryanewnumber1, CommandPromptUtils.courses, out string finalnumber1);

                    Console.WriteLine($"Press a number to choose the {word} please");
                    string tryanewnumber2 = Console.ReadLine();
                    MakeACheck(tryanewnumber2, mylist, out string finalnumber2);

                    int[] anarray = { int.Parse(finalnumber1), int.Parse(finalnumber2) };
                    checks.Add(anarray);
                    return CheckForTheSameChoice(int.Parse(finalnumber1), int.Parse(finalnumber2), checks,
                        mylist, word, out thisisthenumber1, out thisisthenumber2);
                }
            }
            thisisthenumber1 = number1.ToString();
            thisisthenumber2 = number2.ToString();
            return true;
        }

        public static void Reordering(List<U> mylist, out List<U> finalsortedlist) 
        {
            List<string> alist = new List<string>();

            foreach (var item in mylist)
            {
                alist.Add(item.Title);
            }

            var secondlist = alist.Except(new List<string>()).ToList();

            List<U> newlist = new List<U>();

            foreach (var item in secondlist)
            {
                foreach (var item2 in mylist)
                {
                    if (item == item2.Title) 
                    {
                        newlist.Add(item2);
                    }
                }
            }

            finalsortedlist = newlist; 
        }
    }
} 
