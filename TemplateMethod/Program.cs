using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelExporter excelExporter=new ExcelExporter();
            PdfExporter pdfExporter=new PdfExporter();
            excelExporter.GetReport();
            pdfExporter.GetReport();
        }
    }
    //*****************************************************************************
    public abstract class DataExporter
    {
        public void ReadData()
        {
            Console.WriteLine("ReadData");
        }

        public void ProcessData()
        {
            Console.WriteLine("Process Data");
        }

        public abstract void PrintData();

        public void GetReport()
        {
            ReadData();
            ProcessData();
            PrintData();
        }
    }
    //*****************************************************************************
    public class ExcelExporter : DataExporter
    {
        public override void PrintData()
        {
            Console.WriteLine("Excel Export");
        }
    }
    //*****************************************************************************
    public class PdfExporter : DataExporter
    {
        public override void PrintData()
        {
            Console.WriteLine("Pdf Export");
        }
    }
    //*****************************************************************************
}


