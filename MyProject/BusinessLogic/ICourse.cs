using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BusinessLogic
{
    interface ICourse
    {
        string Title { get; set; }

        string Stream { get; set; }

        string Type { get; set; }

        DateTime Start_Date { get; set; }

        DateTime End_Date { get; set; }
    }
}
