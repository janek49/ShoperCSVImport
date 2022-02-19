using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoperCSVImport
{
    public static class ListViewUtil
    {
        public static void ResizeColumnsToViewport(ListView listView)
        {
            int headerWidth = (listView.Width - 40) / listView.Columns.Count;
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = headerWidth;
            }
        }

        public static List<string[]> SerializeListView(ListView listView)
        {
            var list = new List<string[]>();

            foreach(ListViewItem item in listView.Items)
            {
                var row = new string[listView.Columns.Count];
                
                for(int i = 0; i < Math.Min(item.SubItems.Count, listView.Columns.Count); i++)
                    row[i] = item.SubItems[i].Text.Trim();

                list.Add(row);
            }

            return list;
        }

        public static void DisplayStrArrInListView(ListView target, List<string[]> file, int limit = 0)
        {
            target.Items.Clear();
            target.Columns.Clear();

            target.Hide();

            int i = 0;

            foreach (string[] row in file)
            {
                while (target.Columns.Count < row.Length)
                {
                    target.Columns.Add("Kolumna " + (target.Columns.Count + 1));
                    target.Columns[target.Columns.Count - 1].Width = 160;
                }
                target.Items.Add(new ListViewItem(row));
                i++;
                if (limit > 0 && i >= limit) break;
            }

            target.Show();
        }

        public static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
        {
            //make header string
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

            //export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i))
                    continue;

                if (!isFirstTime)
                    result.Append(",");
                isFirstTime = false;

                result.Append(String.Format("\"{0}\"", columnValue(i)));
            }
            result.AppendLine();
        }
    }
}
