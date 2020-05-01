using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class ToDoList
    {
        public string nameOfActiviy { get; set; }
        public string dayForActiviy { get; set; }
        public bool completed { get; set; }

        public ToDoList(string NameofActivity, string DayForActiviy, bool Completed)
        {
            nameOfActiviy = NameofActivity;
            dayForActiviy = DayForActiviy;
            completed = Completed;
        }

        

       
    }
}
