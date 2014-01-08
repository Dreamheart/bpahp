using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Core;
using System.Reflection;
using System.Data;
using System.Data.OleDb;

namespace Mixed_BP_AHP
{
    class ExcelDocument
    {
        private Microsoft.Office.Interop.Excel.Application app = null;
        private Microsoft.Office.Interop.Excel.Workbook workbook = null;

        public ExcelDocument()
        { 
        }

        public ExcelDocument(string file_input)
        {
            this.open(file_input);
        }

        public bool open(string file_input)
        {
            app = new Microsoft.Office.Interop.Excel.ApplicationClass();
            workbook = app.Workbooks.Open(file_input,
                Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,
                Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,
                Missing.Value,Missing.Value,Missing.Value,Missing.Value);
            
            return true;
        }

        public void close()
        {
            app.Workbooks.Close();
            app.Quit();
        }

        public DataSet getDataSet()
        {
            DataSet dsOfWorkbook = new DataSet();

            DataTable tmpTable = null;

            for (int i = 0; i < workbook.Sheets.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[i + 1];

                tmpTable = dsOfWorkbook.Tables.Add(sheet.Name);


                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[2, 3];

                //取得行数
                int iRowsCount = sheet.UsedRange.Cells.Rows.Count;
                //取得列数  
                int iColsCount = sheet.UsedRange.Cells.Columns.Count;

                Console.WriteLine("Rows:" + iRowsCount);
                Console.WriteLine("Columns:" + iColsCount);

            }

            return dsOfWorkbook;
        }

        public DataSet Parse(string fileName)
        {
            //string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};Extended Properties=Excel 8.0;", fileName);

            string connectionString = string.Format("provider= Microsoft.ACE.OLEDB.12.0; data source={0};Extended Properties=Excel 8.0;", fileName);


            DataSet data = new DataSet();

            OleDbConnection con = new OleDbConnection(connectionString);

            con.Open();

            foreach (var sheetName in GetExcelSheetNames(con))
            {
                var dataTable = new DataTable(sheetName.Trim("'".ToCharArray()).TrimEnd("$".ToCharArray()));
                string query = string.Format("SELECT * FROM [{0}]", sheetName);
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                adapter.Fill(dataTable);
                data.Tables.Add(dataTable);
            }
            con.Close();
            return data;
        }

        private string[] GetExcelSheetNames(OleDbConnection con)
        {
            DataTable dt = null;
            dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            if (dt == null)
            {
                return null;
            }

            String[] excelSheetNames = new String[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[i] = row["TABLE_NAME"].ToString();
                i++;
            }

            return excelSheetNames;
        }
    }
}
