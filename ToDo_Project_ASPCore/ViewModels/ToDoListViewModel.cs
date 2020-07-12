using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_Project_ASPCore.Helpers;
using ToDo_Project_ASPCore.Models;

namespace ToDo_Project_ASPCore.ViewModels
{
    public class ToDoListViewModel
    {
        public ToDoListViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new ToDoListItem();
                this.TodoItems = db.Query<ToDoListItem>("SELECT * FROM ToDoListItems ORDER BY AddDate DESC").ToList();
            }
        }

        public List<ToDoListItem> TodoItems { get; set; }

        public ToDoListItem EditableItem { get; set; }
    }
}
