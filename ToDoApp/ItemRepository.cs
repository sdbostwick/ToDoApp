using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ItemRepository
    {
        ItemContext context = new ItemContext();

        public void AddItem(ToDoItem item)
        {
            context.Add(item);
            context.SaveChanges();
        }

        public void DeleteItem(ToDoItem item)
        {
            context.Remove(item);
            context.SaveChanges();
        }
    }
}
