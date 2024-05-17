using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv05
{
    public class DataConsolePrinter
    {
        public static void PrintData(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> data = dataset.GetData();
            foreach (var row in data)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
    }
}
