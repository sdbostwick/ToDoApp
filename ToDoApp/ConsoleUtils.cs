using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ConsoleUtils
    {
        public void PrintDate(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString("MM-dd-yyyy"));
        }

        public string EnterItemDescription()
        {
            Console.WriteLine("Enter an item description");
            return Console.ReadLine();
        }

        public DateTime EnterDueDate()
        {
            DateTime dueDate = DateTime.Now;
            Console.WriteLine("Enter a due date.  Ex:  2/25/2020");
            try
            {
                string due = Console.ReadLine();
                dueDate = DateTime.Parse(due);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return dueDate;
            }
            return dueDate;
        }
    }
}
