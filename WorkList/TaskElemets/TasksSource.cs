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
        internal static string PathElements = $"{Environment.CurrentDirectory}\\Elements.json";

        public static IOServices services = new IOServices(Path);
        public static IOServices elementsServices = new IOServices(PathElements);

        public static BindingList<Tasks> tasks = new BindingList<Tasks>();
        internal static int counter = 2;
        internal static BindingList<Elements> elements= new BindingList<Elements>();
        internal static Elements SelectedElement;

        public static Label label;
    }
}
