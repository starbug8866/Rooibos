using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Windows.Forms;

namespace Rooibos.Library
{
    public class FileHelper
    {
        public static void SaveCsvFile(FileInfo path, DataGridView grid)
        {
            using (TextWriter tw = File.CreateText(path.FullName))
            {
                CsvWriter wr = new CsvWriter(tw);

                foreach(DataGridViewColumn c in grid.Columns)
                {
                    wr.WriteField(c.HeaderText);
                }

                wr.NextRecord();

                foreach(DataGridViewRow r in grid.Rows)
                {
                    foreach(DataGridViewCell c in r.Cells)
                    {
                        wr.WriteField(c.Value);
                    }

                    wr.NextRecord();
                }
            }
        }
    }
}
