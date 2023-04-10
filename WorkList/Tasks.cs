using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList
{
    public  class Tasks
    {

        public Tasks(string Task,  string Priority, DateTime Date, string Time, string Comment,bool Done)
        {
            task = Task;
            priority= Priority;
            date= Date;
            time=Time; 
            comment= Comment;
            done= Done; 
        }


        public string task;
        public string priority;
        public DateTime date;
        public string time;
        public string comment;
        public bool done;
  
    }
}
