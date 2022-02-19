using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ShoperCSVImport
{
    public class TemplateHelper
    {
        public class StanyAdapterConfig
        {
            public int ColumnID, ColumnTitle, ColumnEAN, ColumnAvailable, ColumnPrice;
            public string FilterText;
        }

        public static StanyAdapterConfig ReadConfigFile(string filePath)
        {
            var js = new JavaScriptSerializer();
            string ctx = File.ReadAllText(filePath);
            return js.Deserialize<StanyAdapterConfig>(ctx);
        }

        public static void WriteConfigFile(string filePath, StanyAdapterConfig cfg)
        {
            var js = new JavaScriptSerializer();
            string ctx = js.Serialize(cfg);
            File.WriteAllText(filePath, ctx);
        }
    }
}
