using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Resources;

namespace Serwis
{
    class Printer
    {
        public Printer(string place, string manufacturer, string model, string serialNo, string type, string damageDesc, string user)
        {
            string path = this.createPDF(place, manufacturer, model, serialNo, type, damageDesc, user);
            this.SendToPrinter(path);
        }
        private void SendToPrinter(string path)
        {
            var confirmResult = MessageBox.Show("Czy chcesz wydrukować potwierdzenie?",
                                     "Drukowanie",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.Verb = "print";
                info.FileName = path;
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process p = new Process();
                p.StartInfo = info;
                p.Start();

                p.WaitForInputIdle();
                System.Threading.Thread.Sleep(3000);
                if (false == p.CloseMainWindow())
                    p.Kill();
            }
        }
        private string createPDF(string place, string manufacturer, string model, string serialNo, string type, string damageDesc, string user)
        {
            if (!Directory.Exists(Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents") + @"\PDF"))
                Directory.CreateDirectory(Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents") + @"\PDF");
            var template = Serwis.Properties.Resources.template;
            string newFile = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents") + @"\PDF\confirmation_" + serialNo + "_" + DateTime.Now.ToShortDateString() + ".pdf";
            PdfReader reader = new PdfReader(template);
            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(newFile, FileMode.Create)))
            {
                AcroFields fields = stamper.AcroFields;

                // set form fields
                fields.SetField("place", place);
                fields.SetField("date", DateTime.Now.ToLocalTime().ToString());
                fields.SetField("manufacturer", manufacturer);
                fields.SetField("model", model);
                fields.SetField("serialNo", serialNo);
                fields.SetField("type", type);
                fields.SetField("damageDesc", damageDesc);
                fields.SetField("user", user);

                // flatten form fields and close document
                stamper.FormFlattening = true;
                stamper.Close();
            }
            return newFile;
        }
    }
}
