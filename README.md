# CRCXMODEM
CRC-XMODEM 算法

主方法调用-SendData
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
        Console.WriteLine("串口打开成功");
    else
        Console.WriteLine("串口打开失败");
    // 启动接收线程
    Thread th1 = new Thread(receivedata);
    if (th1 != null)
        th1.Start();
    Console.ReadLine();
    SendData(StrCommon.GetEnumText(FunList.初始化不移动卡), FunList.初始化不移动卡.ToString());
    Console.ReadLine();
    
    SendData(StrCommon.GetEnumText(FunList.查卡机状态), FunList.查卡机状态.ToString());
    Console.ReadLine();

    SendData(StrCommon.GetEnumText(FunList.将卡移动到RF卡位), FunList.将卡移动到RF卡位.ToString());
    Console.ReadLine();

    SendData(StrCommon.GetEnumText(FunList.将卡移到出卡口持卡位), FunList.将卡移到出卡口持卡位.ToString());
    Console.ReadLine();

    SendData(StrCommon.GetEnumText(FunList.使能前端进卡), FunList.使能前端进卡.ToString());
    Console.ReadLine();

    SendData(StrCommon.GetEnumText(FunList.将卡移动到发卡栈), FunList.将卡移动到发卡栈.ToString());
    Console.ReadLine();
}

CRC/XMODEL算法
/// <summary>
/// 高位在前，低位在后
/// </summary>
/// <param name="x"></param>
/// <param name="len"></param>
/// <returns></returns>
public static byte[] GetCrcByByteArray(byte[] x, int len) //CRC校验函数
{
    byte[] temdata = new byte[2];
    UInt16 crc = 0;
    byte da;
    int i = 0;
    UInt16[] yu = { 0x0000,0x1021,0x2042,0x3063,0x4084,0x50a5,0x60c6,0x70e7,
        0x8108,0x9129,0xa14a,0xb16b,0xc18c,0xd1ad,0xe1ce,0xf1ef };
    while (len-- != 0)
    {

        da = (byte)(((byte)(crc / 256)) / 16);
        crc <<= 4;
        crc ^= yu[da ^ x[i] / 16];
        da = (byte)(((byte)(crc / 256)) / 16);
        crc <<= 4;
        crc ^= yu[da ^ x[i] & 0x0f];
        i++;
    }
    #region 低位在前，高位在后
    //temdata[0] = (byte)(crc & 0xFF);
    //temdata[1] = (byte)(crc >> 8);
    #endregion
    temdata[0] = (byte)(crc >> 8);
    temdata[1] = (byte)(crc & 0xFF);
    return temdata;
}
