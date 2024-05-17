using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv05
{
    public interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
