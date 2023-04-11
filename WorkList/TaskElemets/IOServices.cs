using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList.TaskElemets
{
    internal class IOServices
    {
        private readonly string _path;

        public IOServices(string path)
        {
            _path = path;
        }

        public BindingList<Products> LoadData()
        {
            if (!File.Exists(_path))
            {
                File.CreateText(_path).Dispose();
                return new BindingList<Products>();
            }

            using (var reader = File.OpenText(_path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Products>>(fileText);
            }
        }

        public void SaveData<T>(T productsinfo)
        {
            using (StreamWriter writer = File.CreateText(_path))
            {
                string output = JsonConvert.SerializeObject(productsinfo);
                writer.WriteLine(output);
            }
        }

    }
}
