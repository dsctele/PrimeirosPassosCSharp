using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args);
        List<Tag_Model> dataList = new List<Tag_Model>();
        static RFIDReaderAPI.Param_Option PARAM_SET = new RFIDReaderAPI.Param_Option();
        static RFIDReaderAPI.RFID_Option RFID_OPTION = new RFIDReaderAPI.RFID_Option();
        static string tid = "E280110C20007719E0B20973";
        static string epc = "ADB5F1DC518721D7710158EF";
        static string ConnID = "192.168.1.116:9090";
        string usbConnID = @"\\?\hid#vid_2121&pid_8633#6&297867e4&0&0000#{4d1e55b2-f16f-11cf-88cb-00111
1000030}";
        static string SerialConnId = "COM3:115200";

        string tcp = "192.168.1.116:9090";
        RFIDReaderAPI.Interface.IAsynchronousMessage log = new Program();
if (RFIDReaderAPI.RFIDReader.CreateTcpConn(tcp, log))
{
var rt = RFIDReader._ReaderConfig.GetReaderGPIState(tcp);
        Console.WriteLine(rt);
}
}
}
