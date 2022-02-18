using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Xml.Linq;
using System.Net;
using NReco.Csv;

namespace ebay_Templates
{
    public static class Util1
    {
        


        public static string OpenFileDialog(string filter)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }

        public static string ReplaceFirst(this string text, string search, string replace)
        {
            
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        public static bool HasUpdateConnection()
        {
            
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://dropbox.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetCurrentDir()
        {
            
            return Directory.GetCurrentDirectory();
        }

        public static byte[] CompressBytesGzip(byte[] raw)
        {
            
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                    CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return memory.ToArray();
            }
        }

        public static bool TryCatch(Action action)
        {
            
            try
            {
                action();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal static void PrzetwórzWyjątek(Exception ex)
        {
            
            MessageBox.Show("Interner Anwendungsfehler!\n\nInformationen für den Entwickler:\n\n" + ex.ToString(), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string FixFormatting(string input)
        {
            
            var rexAllowedOnly = new Regex(@"<font.*?>");
            string rep1 = rexAllowedOnly.Replace(input, "").Replace("</font>", "");

            var regex = new Regex(@"<li.*?>");
            string rep2 = regex.Replace(rep1, "").Replace("</li>", "<br>");
            string rep3 = rep2.Replace("<div style=\"font-size: 14pt;\"><br></div>", "");

            return "<center>" + rep3 + "</center>";
        }


        internal static string CsvRTs(string v, CsvReader itr)
        {
            List<string> strs = new List<string>();
            for(int i = 0; i<itr.FieldsCount; i++)
            {
                strs.Add(itr[i]);
            }
            return string.Join(v, strs.ToArray());
        }

        internal static string IsoDateTimeNowFile()
        {
            return DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
        }

        public static string FixFormattingNoCenter(string input)
        {
            
            var rexAllowedOnly = new Regex(@"<font.*?>");
            string rep1 = rexAllowedOnly.Replace(input, "").Replace("</font>", "");

            var regex = new Regex(@"<li.*?>");
            string rep2 = regex.Replace(rep1, "").Replace("</li>", "<br>");
            string rep3 = rep2.Replace("<div style=\"font-size: 14pt;\"><br></div>", "");

            return rep3;
        }

        public static T[] AddToArrayBeginning<T>(T[] array, params T[] elements)
        {
            
            List<T> l = new List<T>();
            l.AddRange(elements);
            l.AddRange(array);
            return ListaNaArray(l);
        }

        public static T[] AddToArrayEnd<T>(T[] array, params T[] elements)
        {
            
            List<T> l = new List<T>();
            l.AddRange(array);
            l.AddRange(elements);
            return ListaNaArray(l);
        }

        public static IEnumerable<List<T>> splitList<T>(List<T> locations, int nSize)
        {
            
            for (int i = 0; i < locations.Count; i += nSize)
            {
                yield return locations.GetRange(i, Math.Min(nSize, locations.Count - i));
            }
        }

        public static string RemoveHtmlTags(string input)
        {
            
            return Regex.Replace(input.Replace("<br>", "\r\n"), "<.*?>", String.Empty);
        }

        public static Object GetSafe(dynamic xml, string v)
        {
            
            Object val;
            return ((IDictionary<String, Object>)xml).TryGetValue(v, out val) ? (Object)val : null;
        }

        public static string SubString(string s, int start, int end)
        { 
            return s.Substring(start, end - start + 1);
        }

        public static String sklej(string[] co, string znak)
        {
            
            string tmp = "";
            foreach (string str in co)
            {
                if (str != null && str.Replace(" ", "").Length > 0) tmp += znak + str;
            }
            string exdd = "";
            try
            {
                exdd = tmp.Substring(1);
            }
            catch (Exception)
            {

            }
            return exdd;
        }

        public static bool containsListView(ListView listView1, int v1, string v2)
        { 
            foreach (ListViewItem lvi in listView1.Items)
            {
                if (lvi.SubItems[v1].Text.Equals(v2)) return true;
            }
            return false;
        }

        public static string[] ListToStringArray(List<object> lista)
        {
            
            string[] arr = new string[lista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                arr[i] = lista[i].ToString();
            }
            return arr;
        }

        public static T[] ListaNaArray<T>(IEnumerable<T> lista)
        {
            
            T[] arr = new T[lista.Count()];
            for (int i = 0; i < lista.Count(); i++)
            {
                arr[i] = lista.ElementAt(i);
            }
            return arr;
        }

        public static string int2digits(int i)
        {
            
            return i < 10 ? "0" + i : i + "";
        }

        public static String[] odklej(string co, char znak)
        {
            
            return co.Split(znak);
        }

        public static String klejZnak(string znak, int ile)
        { 
            string s = "";
            for (int i = 0; i < ile; i++)
            {
                s += znak;
            }
            return s;
        }


        public static string IsoDateNow()
        {
            return IsoDate(DateTime.Now);
        }

        public static string IsoDateTimeNow()
        {
            return IsoDateTime(DateTime.Now);
        }

        public static string IsoDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static string IsoDateTime(DateTime time)
        {
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }


        public static string RemoveUmlauts(string str)
        { 
            // duże i małe a-umlaut		
            return str.Replace("\u00C4", "AE").Replace("\u00E4", "ae")
                // duże i małe o-umlaut
                .Replace("\u00D6", "OE").Replace("\u00F6", "oe")
                // duże i małe u-umlaut
                .Replace("\u00DC", "UE").Replace("\u00FC", "ue")
                // duże i małe scharfes s
                .Replace("\u1E9E", "SS").Replace("\u00DF", "ss");
        }

        internal static ListViewItem ListViewItem(params object[] p)
        { 
            string[] strs = new string[p.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = p[i] == null ? "" : p[i].ToString();
            }
            return new ListViewItem(strs);
        }

        internal static ListViewItem ElementListViewaTrim(char trim, params object[] p)
        { 
            string[] strs = new string[p.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = p[i] == null ? "" : p[i].ToString().Trim(trim);
            }
            return new ListViewItem(strs);
        }

        internal static string SpróbójWczytać(string v)
        {
            
            try
            {
                return File.ReadAllText(v);
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal static string FormatujCenę(double price)
        {
            
            string sr = Math.Round(price, 2).ToString();
            string[] sc = sr.Split(',');
            if (sc.Length == 1) sr += ",00"; else if (sc.Length > 1) if (sc[1].Length < 2) sr += "0";
            return sr + " EUR";
        }



        static public double getUnixTime(DateTime dateTime)
        {
            
            return (Int32)(TimeZoneInfo.ConvertTimeToUtc(dateTime) -
                   new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }


        static public string getMD5(string input)
        {
            
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static Bitmap skalujObraz(Image obraz, int szerokość, int wysokość)
        {
            
            var destRect = new Rectangle(0, 0, szerokość, wysokość);
            var destImage = new Bitmap(szerokość, wysokość);

            destImage.SetResolution(obraz.HorizontalResolution, obraz.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(obraz, destRect, 0, 0, obraz.Width, obraz.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return new Bitmap(destImage, szerokość, wysokość);
        }

        public static Bitmap WytnijObraz(Bitmap source, Rectangle section)
        {
            
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        public static string getMd5Hash(byte[] buffer)
        {
            
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(buffer);

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static void TryCreateDir(string v)
        {
            
            try
            {
                if (!Directory.Exists(v)) Directory.CreateDirectory(v);
            }
            catch (Exception)
            {
            }
        }

        public static byte[] imageToByteArray(Image image)
        {
            
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Bmp);
            return ms.ToArray();
        }

        public static DialogResult ShowInputDialog(string title, string text, ref string input)
        {
            
            System.Drawing.Size size = new System.Drawing.Size(400, 125);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.Text = title;

            Label label = new Label();
            label.Size = new System.Drawing.Size(size.Width - 10, 28);
            label.Location = new System.Drawing.Point(5, 10);
            label.Font = new Font("Lato", 16, FontStyle.Regular);
            label.Text = text;
            inputBox.Controls.Add(label);

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 20, 23);
            textBox.Location = new System.Drawing.Point(10, 50);
            textBox.Font = new Font("Lato", 12, FontStyle.Regular);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 28);
            okButton.Text = "&OK";
            okButton.Font = new Font("Lato", 10, FontStyle.Regular);
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 85, 90);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 28);
            cancelButton.Text = "&Anuluj";
            cancelButton.Font = new Font("Lato", 10, FontStyle.Regular);
            cancelButton.Location = new System.Drawing.Point(size.Width - 85, 90);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text.Length == 0 ? null : textBox.Text;
            return result;
        }

        public static bool JestNumerem(string str)
        {
            
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return !str.Equals("");
        }



        public static string ArrayToString(string[] v, string sep = ",")
        { 
            string s = "";
            foreach (string str in v)
            {
                s += sep + str;
            }
            return s.Length == 0 ? s : s.Substring(sep.Length);
        }
        public static string Truncate(this string value, int maxLength)
        {
            
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
        public static List<T> ArrayToList<T>(params T[] obj)
        {
            
            List<T> list = new List<T>();
            foreach (T o in obj)
            {
                list.Add(o);
            }
            return list;
        }

        public static List<object> DynamicOneOrMoreList(dynamic dyn, string v)
        {
            
            if (((IDictionary<String, object>)dyn).ContainsKey(v))
            {
                try
                {
                    return (List<object>)((IDictionary<String, object>)dyn)[v];
                }
                catch (Exception)
                {
                    return Util1.ArrayToList((object)((IDictionary<String, object>)dyn)[v]);
                }
            }
            else return new List<object>();//throw new NullReferenceException("dynamic ExpandoObject does not contain key '" + v + "'");
        }


        public static bool JeśliOstrzeż(bool v1, string v2)
        {
            
            if (v1) MessageBox.Show(v2, "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return v1;
        }

        public static string ListToString(List<string> list, string sep = ",")
        {
            
            return ArrayToString(ListaNaArray(list), sep);
        }

        public static string KodujBase64(string str)
        {
            
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(str);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string DekodujBase64(string str)
        {
            
            var base64EncodedBytes = System.Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }



        public static void UpdateMultiControls(string textProperty, params Control[] controls)
        {
            
            foreach (Control c in controls) c.Text = textProperty;
        }

        public static string WithMaxLength(string value, int maxLength)
        {
            
            return value?.Substring(0, Math.Min(value.Length, maxLength));
        }

        public static void TrimArray(string[] fields, char v)
        {
            
            for (int i = 0; i < fields.Length; ++i)
            {
                fields[i] = fields[i].Trim(v);
            }
        }

        public static void DlaKażdego<T>(IEnumerable<T> kolekcja, Action<T> akcja)
        {
            foreach (T t in kolekcja)
                akcja(t);
        }

        public static string JoinNotEmpty(string sep, bool trim, params string[] arr)
        { 
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (trim ? !string.IsNullOrWhiteSpace(arr[i]) : !string.IsNullOrEmpty(arr[i]))
                {
                    if (i != 0) str += sep;
                    str += arr[i];
                }
            }
            return str;
        }
    }
}
