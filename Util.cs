using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShoperCopy
{
    public static class Util
    {
        public static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public static void Invoke(Control c, Action p)
        {
            c.Invoke((MethodInvoker)delegate { p.Invoke(); });
        }

        public static void SetDpiScaling(Control ctr)
        {
            if (ctr.GetType() == typeof(ContainerControl))
            {
                ((ContainerControl)ctr).AutoScaleMode = AutoScaleMode.Dpi;
            }

            foreach(Control child in ctr.Controls)
            {
                SetDpiScaling(child);
            }
        }

        public static string Format(this string str, params object[] args)
        {
            return string.Format(str, args);
        }

        public static void WriteImageJpg(Image img, string file, int quality)
        {
            ImageCodecInfo koder = Util.GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters parametry = new EncoderParameters(1);
            EncoderParameter par = new EncoderParameter(encoder, quality);
            parametry.Param[0] = par;
            img.Save(file, koder, parametry);
        }

        
        public static Image ImageFromBytes(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                return Image.FromStream(stream);
            }
        }

        public static List<T> ArrayToList<T>(params T[] array)
        {
            return new List<T>(array);
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

        public static void SetProgressBarInstant(ProgressBar bar, int val)
        {
            if (bar.Value < bar.Maximum)
            {
                bar.Maximum += 1;
                bar.Value = val;
                bar.Value = val + 1;
                bar.Value = val;
                bar.Maximum -= 1;
            }
            else
            {
                bar.Value = val;
                bar.Value = val + 1;
                bar.Value = val;
            }
        }

        public static string RemoveIllegalForFile(this string str)
        {
            return new Regex(@"[\\/:*?""<>|]").Replace(str, "");
        }

       

        public static Bitmap ReadImageFromFileSafe(string file)
        {
            Bitmap imgN = null;
            try
            {
                using (var img = Image.FromFile(file))
                {
                    imgN = new Bitmap(img);
                    return imgN;
                }
            }
            catch (Exception)
            { 
            }

            

            return imgN;
        }

        public static void HandleException(Exception ex)
        {
            MessageBox.Show("Wystąpił błąd:\n\n" + ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool HandleExceptionRetry(Exception ex)
        {
            return MessageBox.Show("Wystąpił błąd:\n\n" + ex.ToString(), "Błąd", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry;
        }


        public static bool IsValidGtin(string code)
        {
            if (code.Length == 0) return true;
            if (code != (new Regex("[^0-9]")).Replace(code, ""))
            {
                // is not numeric
                return false;
            }
            // pad with zeros to lengthen to 14 digits
            switch (code.Length)
            {
                case 8:
                    code = "000000" + code;
                    break;
                case 12:
                    code = "00" + code;
                    break;
                case 13:
                    code = "0" + code;
                    break;
                case 14:
                    break;
                default:
                    // wrong number of digits
                    return false;
            }
            // calculate check digit
            int[] a = new int[13];
            a[0] = int.Parse(code[0].ToString()) * 3;
            a[1] = int.Parse(code[1].ToString());
            a[2] = int.Parse(code[2].ToString()) * 3;
            a[3] = int.Parse(code[3].ToString());
            a[4] = int.Parse(code[4].ToString()) * 3;
            a[5] = int.Parse(code[5].ToString());
            a[6] = int.Parse(code[6].ToString()) * 3;
            a[7] = int.Parse(code[7].ToString());
            a[8] = int.Parse(code[8].ToString()) * 3;
            a[9] = int.Parse(code[9].ToString());
            a[10] = int.Parse(code[10].ToString()) * 3;
            a[11] = int.Parse(code[11].ToString());
            a[12] = int.Parse(code[12].ToString()) * 3;
            int sum = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10] + a[11] + a[12];
            int check = (10 - (sum % 10)) % 10;
            // evaluate check digit
            int last = int.Parse(code[13].ToString());
            return check == last;
        }
    }
}
