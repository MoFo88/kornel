using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex = Microsoft.Office.Interop.Excel;

namespace Kolejki.F
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace EstevesPlanner
    {
        public class Excel
        {
            public Ex.Application exc;
            public Ex.Workbooks workbooks;
            public Ex.Workbook workbook;
            public Ex.Sheets sheets;

            public List<Ex._Worksheet> worksheets = new List<Ex._Worksheet>();

            public List<XY> xy = new List<XY>();
            public class XY
            {
                public int X { get; set; }
                public int Y { get; set; }
            }

            public Excel(int worksheetsCount)
            {
                exc = new Ex.Application();
                workbooks = exc.Workbooks;
                workbook = exc.Workbooks.Add(Type.Missing);
                exc.Sheets.Add(Type.Missing);
                exc.Sheets.Add(Type.Missing);
                sheets = exc.Sheets;

                for (int i = 1; i <= worksheetsCount; i++)
                {

                    Ex._Worksheet worksheet = ((Ex._Worksheet)(sheets[i]));
                    Ex.Range range1;

                    worksheet.Name = "Arkusz_" + i;
                    Ex.Range xlCells;
                    range1 = worksheet.Cells;
                    xlCells = worksheet.Cells;

                    worksheets.Add(worksheet);

                    xy.Add(new XY { X = 1, Y = 1 });
                }

                object misValue = System.Reflection.Missing.Value;
                exc.Visible = true;

                
            }

            public void WriteRow(int ws, List<object> row)
            {
                ResetX(ws);
                foreach (object s in row)
                {
                    worksheets[ws].Cells[xy[ws].Y, xy[ws].X] = s;
                    xy[ws].X++;
                }
                xy[ws].Y++;
            }

            public void WriteRow(int ws,object s)
            {
                ResetX(ws);
                worksheets[ws].Cells[xy[ws].Y, xy[ws].X] = s;
                xy[ws].Y++;
            }

            public void ResetX(int ws)
            {
                xy[ws].X = 1;
            }
        }
    }

}
