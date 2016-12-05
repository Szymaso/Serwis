using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using iTextSharp.text.pdf;

namespace Serwis
{
    class Printer
    {
        public Printer()
        {
            this.createPDF();
           // this.SendToPrinter();
        }
        private void SendToPrinter()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"..\..\..\PDF\file.pdf";
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
        private void createPDF()
        {
            string template = @"..\..\..\PDF\template.pdf";
            string newFile = @"..\..\..\PDF\confirmation_" + DateTime.Now.ToShortDateString() + ".pdf";
            PdfReader reader = new PdfReader(template);
            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(newFile, FileMode.Create)))
            {
                AcroFields fields = stamper.AcroFields;

                // set form fields
                fields.SetField("place", "Miejsce");
                fields.SetField("date", "15.11.2016");
                fields.SetField("manufacturer", "Producent");
                fields.SetField("model", "Model");
                fields.SetField("serialNo", "Numer");
                fields.SetField("type", "Typ");
                fields.SetField("damageDesc", "dsfddddddddddddddddddddd dddddddddddddddddd dddddddddddddddd ddddddddddddddddd dddddddddddddddddddddddddddd ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
                fields.SetField("user", "Serwisant");

                // flatten form fields and close document
                stamper.FormFlattening = true;
                stamper.Close();
            }
        }
    }
}
