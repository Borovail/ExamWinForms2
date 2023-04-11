using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList.TaskElemets
{
    internal static class TasksSource
    {
        public static IOServices services = new IOServices(Path);
         static string Path = $"{Environment.CurrentDirectory}\\";
        public static BindingList<Tasks> tasks = new BindingList<Tasks>();
    }
}
