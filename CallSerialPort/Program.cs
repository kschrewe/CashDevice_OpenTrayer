using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
//using System.Diagnostics;
using System.Text;
using OICFiscalPrinterLib;

namespace CallSerialPort
{
    class Program
    {
        static void Main(string[] args)
        {

            IOICFiscalPrinter FP = new OICFiscalPrinterClass();
            
            //args.

            FP.PortName = "COM5";
            FP.Timeout = 6;

            FP.Open();
            FP.OpenDrawer();            
            FP.Close();

        }

    }
}
