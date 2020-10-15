using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Util
{
    public static class ObjectConversion
    {
        public static DataTable GetDataTable(this Dictionary<string, List<string>> data)
        {
            DataTable dt = new DataTable();

            foreach (var key in data.Keys)
            {
                dt.Columns.Add(key);

                List<string> columnValues = new List<string>();

                foreach (string columnValue in data[key])
                {
                    columnValues.Add(columnValue);
                }

                while (dt.Rows.Count < columnValues.Count)
                {
                    dt.Rows.Add();
                }

                for (int rowNo = 0; rowNo < columnValues.Count; rowNo++)
                {
                    dt.Rows[rowNo][key] = columnValues[rowNo];
                }
            }
            return dt;
        }
    }
}
