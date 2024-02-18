using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.Classes
{
    public class Operation
    {
        public static DataTable ConvertToDataTable<T>(List<T> list, Type type)
        {
            var resultTable = new DataTable();
            resultTable.Columns.Add("Code", type);

            foreach (T x in list)
            {
                resultTable.Rows.Add(x);
            }

            return resultTable;
        }
    }
}
