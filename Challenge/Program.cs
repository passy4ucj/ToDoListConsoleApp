using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Lists listss = new Lists();

            ToDoList activity1 = new ToDoList("Coding", "Monday", false);
            listss.ToDoListss.Add(activity1);
            ToDoList activity2 = new ToDoList("Reading", "Tuesday", true);
            listss.ToDoListss.Add(activity2);
            ToDoList activity3 = new ToDoList("Playng", "Wednesday", false);
            listss.ToDoListss.Add(activity3);

            Console.Write("Please enter your name : ");
            var name = Console.ReadLine();

            

         
            Console.WriteLine("Hello, "+name+" welcome to your To-Do-List: \n Press (n) to create a new To-Do-List" +
                "\n Press (e) to edit your To-Do-List \n Press (s) to show all your To-Do-List");
            Console.Write("Enter character : ");
            string action = Console.ReadLine();

           
            if (action == "n")
            {
                Console.Write("Please enter the new activity you intend to carry out :");
                string newActivity = Console.ReadLine();
                Console.Write("Please enter the Day you intend to carry out this activity :");
                string newDay = Console.ReadLine();
                bool newActivityStatus = false;

                ToDoList newActivityList = new ToDoList(newActivity, newDay, newActivityStatus);

                
                listss.ToDoListss.Add(newActivityList);

                Console.WriteLine("You have successfully addded a To-Do-List");

               
                listss.ShowLists();

            }
          
            else if (action == "s")
            {
                
                listss.ShowLists();
            }
            else if (action == "e")
            {

                Console.WriteLine("Hello, Please select as follows \n press (n) to edit name of To-Do-List" +
                    "\n Press (d) to edit Day of To-Do \n Press (c) to edit if completed");
                Console.Write("Enter option : ");
                string selectAction = Console.ReadLine();
                Console.WriteLine("---------------------------------");

                switch (selectAction)
                {
                    case "n" :
                        Console.Write("Please enter the To-Do name you want to edit  : ");
                        string activitySearch = Console.ReadLine();
                        bool listFound = false;
                        for (int i = 0; i < listss.ToDoListss.Count; i++)
                        {
                            if (listss.ToDoListss[i].nameOfActiviy == activitySearch)
                            {
                                Console.WriteLine(listss.ToDoListss[i].nameOfActiviy);
                                listFound = true;

                                Console.WriteLine("enter new activity : ");
                                listss.ToDoListss[i].nameOfActiviy = Console.ReadLine();
                                Console.WriteLine("---------------------------------------");
                                listss.ShowLists();
                            }
                        }
                        if (!listFound)
                        {
                            Console.WriteLine("Activity Found");
                        }
                        break;

                    case "d":
                        Console.Write("Please enter the To-Do Day you want to edit  : ");
                        string daySearch = Console.ReadLine();
                        bool dayFound = false;
                        for (int i = 0; i < listss.ToDoListss.Count; i++)
                        {
                            if (listss.ToDoListss[i].dayForActiviy == daySearch)
                            {
                                Console.WriteLine(listss.ToDoListss[i].dayForActiviy);
                                listFound = true;

                                Console.WriteLine("enter new Day");
                                listss.ToDoListss[i].dayForActiviy = Console.ReadLine();

                                listss.ShowLists();
                            }
                        }
                        if (!dayFound)
                        {
                            Console.WriteLine("Day Found");
                        }
                        break;

                    case "c":
                        Console.Write("Please edit To-Do Completion  : ");
                        bool statusSearch = Convert.ToBoolean(Console.ReadLine());
                        bool statusFound = false;
                        for (int i = 0; i < listss.ToDoListss.Count; i++)
                        {
                            if (listss.ToDoListss[i].completed)
                            {
                                Console.WriteLine(listss.ToDoListss[i].completed);
                                statusFound = true;

                                Console.WriteLine("Change Status : ");
                                listss.ToDoListss[i].completed = Convert.ToBoolean(Console.ReadLine());

                                listss.ShowLists();
                            }
                        }
                        if (!statusFound)
                        {
                            Console.WriteLine("Status Found");
                        }
                        break;


                    default:
                        break;
                }

                
            }

        }
    }
}
