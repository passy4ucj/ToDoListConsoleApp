using System;
using System.Collections.Generic;

namespace Challenge
{
    class Lists
    {
        public List<ToDoList> ToDoListss = new List<ToDoList>();


        public void ShowLists()
        {
            
            Console.WriteLine("Name of activity     |||  Day to carry out activity   |||   completed");
            foreach (var item in ToDoListss)

            {

                Console.WriteLine(" {0}                          {1}                         {2}       ", item.nameOfActiviy, item.dayForActiviy, item.completed);
            }
        }
    }
}
