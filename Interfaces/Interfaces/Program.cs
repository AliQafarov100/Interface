using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            MainPrintFile printedFile = new Word("Word");
            printedFile.Print();

            //PDF pdf = new PDF("Pdf");
            //Word words = new Word("Word");
            //MainPrintFile printFile = pdf;
            //MainPrintFile printFile1 = words;
            //printFile.Print();
            //printFile1.Print();
        }
    }
}
