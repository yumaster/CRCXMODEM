using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRCXMODEM
{
    class Program
    {
        //声明串口类实例
        private static SerialPort port = null;

        static void Main(string[] args)
        {
            // 配置串口
            port = new SerialPort("COM3");
            port.BaudRate = 115200;
            port.DataBits = 8;
            port.Parity = Parity.Even;
            port.StopBits = StopBits.One;

            port.Open();

            // 打开
            if (port.IsOpen)
            {
                Console.WriteLine("串口打开成功");
            }
            else
            {
                Console.WriteLine("串口打开失败");
            }
            // 启动接收线程
            Thread th1 = new Thread(receivedata);
            if (th1 != null)
                th1.Start();

            SendData(StrCommon.GetEnumText(FunList.初始化不移动卡));
            Console.ReadLine();

            SendData(StrCommon.GetEnumText(FunList.查卡机状态));
            Console.ReadLine();

            SendData(StrCommon.GetEnumText(FunList.将卡移动到RF卡位));
            Console.ReadLine();

            SendData(StrCommon.GetEnumText(FunList.将卡移到出卡口持卡位));
            Console.ReadLine();

            SendData(StrCommon.GetEnumText(FunList.使能前端进卡));
            Console.ReadLine();

            SendData(StrCommon.GetEnumText(FunList.将卡移动到发卡栈));
            Console.ReadLine();
        }

        // 接收线程
        public static void receivedata()
        {
            while (true)
            {
                byte[] rec = new byte[10];
                port.Read(rec, 0, 10);//读取缓冲数据
                string str = StrCommon.GetHexStrByByteArray(rec);
                Console.WriteLine("接收线程:{0}", str);
                Thread.Sleep(500);
            }
        }
        // 发送线程
        public static void SendData(string comStr)
        {
            string cmd = StrCommon.GetSerialCommand(comStr);
            byte[] cmdByteArr = StrCommon.GetByteArrayByHexStr(cmd);
            port.Write(cmdByteArr, 0, cmdByteArr.Length);
            Console.WriteLine("发送线程:" + cmd);
        }
        
    }
}
