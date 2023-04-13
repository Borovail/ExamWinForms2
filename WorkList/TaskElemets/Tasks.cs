using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace WorkList.TaskElemets
{
    public class Tasks
    {

        public Tasks(string Task, object Priority, DateTime Date, string Time, string Comment, bool Done)
        {
            task = Task;
            priority = Priority;
            date = Date;
            time = Time;
            comment = Comment;
            done = Done;
        }


        public string task;
        public object priority;
        public DateTime date;
        public string time;
        public string comment;
        public bool done;

    }
}
