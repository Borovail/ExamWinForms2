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
        internal static string Path = $"{Environment.CurrentDirectory}\\Tasks.json";
        public static IOServices services = new IOServices(Path);
        public static BindingList<Tasks> tasks = new BindingList<Tasks>();
        internal static int counter = 0;
        internal static BindingList<Elements> elements= new BindingList<Elements>();
        internal static Elements SelectedElement;
    }
}
