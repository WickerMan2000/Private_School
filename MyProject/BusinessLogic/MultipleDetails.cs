using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    class MultipleDetails<T>
    {
        public delegate T GetTheDetails(List<string> subjects = null);

        public static List<T> GetMultipleDetails(GetTheDetails DifferentDetails)
        {
            List<T> mylist = new List<T>();
            while (true) 
            {
                Console.WriteLine("............New Case............");
                mylist.Add(DifferentDetails());
                Console.WriteLine("If you want to stop type yes. Else type no");
                string command = Console.ReadLine();
                if (ToolBox.Choice(command) == "yes")
                    break;
                else
                    continue;
            }
            ToolBox.CheckForTheDoubles(mylist, out List<T> checkedlist);
            return checkedlist;
        }

        public static void Iteration(List<T> myList)
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
