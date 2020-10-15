using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Util
{
    public static class SaveImages
    {
        public static void SaveImagesToDisk(DataTable tabletImageInfoDataTable)
        {
            foreach (FileInfo file in new DirectoryInfo(Environment.CurrentDirectory + "\\TabletImages").EnumerateFiles())
            {
                file.Delete();
            }

            foreach (DataRow row in tabletImageInfoDataTable.Rows) {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(row["TabletImageLink"].ToString()), Environment.CurrentDirectory + "\\TabletImages\\" + row["TabletName"].ToString() + ".jpg");
                }
            }
        }
    }
}
