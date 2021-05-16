using System;
using System.Collections.Generic;
using System.Text;

namespace KudvenkatISP
{
    interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }

    class HPLaserJet_ISP : IPrintScanContent, IFaxContent, IPrintDuplex
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }

    class CannonMG2470_ISP : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
