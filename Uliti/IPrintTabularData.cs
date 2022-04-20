using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTableInConsole
{
    public interface IPrintTabularData<TData>
    {
        void PrintTable(IEnumerable<TData> data);
    }
}
