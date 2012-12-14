using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Data;
namespace Woodensoft.Tither.Utilities
{
    public static class ExcelExporter
    {
        public static string Export(DataTable dt, string baseFileName)
        {
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt);
            var fileName = baseFileName + DateTime.Now.ToString("yyyyMMddhhddssfff") + ".xsl";
            wb.SaveAs(fileName);
            return fileName;
        }

        public static DataTable ConvertToDataTable<TE>(IEnumerable<TE> list, string tableName)
        {
            var dt = new DataTable(tableName);
            if(!list.Any())
            {
                return dt;
            }
            var ele = list.First();
            var props = ele.GetType().GetProperties();
            foreach(var prop in props)
            {
                dt.Columns.Add(prop.Name, typeof(string));
            }
            foreach (var element in list)
            {
                var dr = dt.NewRow();
                foreach (var prop2 in props)
                {
                    var val = prop2.GetValue(element, null);
                    dr[prop2.Name] = val == null ? "" : val.ToString();
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
