using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Comon;
using Comon.SocketChanle;
using SocketExentd;

namespace TestExentd
{
    public class Class1
    {
        public static void TestUntils()
        {
            for (int i = 0; i < 100000; i++)
            {    
                var convertByteArrayToInt = bytesUntils.ConvertIntToByteArray(i);

                var ToInt = bytesUntils.ConvertByteArrayToInt(convertByteArrayToInt);

                if(i != ToInt) throw new Exception("测试未通过");

            }

            for (long i = 0; i < 100000; i++)
            {
                           
                var bytes = bytesUntils.ConvertLongToByteArray(i);

                var ToLong = bytesUntils.ConvertByteArrayToLong(bytes);

                if(i != ToLong) throw new Exception("测试未通过");
            }
        }

        public static async void Server()
        {
            Socket socket=new Socket(AddressFamily.InterNetwork, 
                SocketType.Stream, ProtocolType.Tcp);
            
            socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"),5000));
    
            socket.Listen(10);
            Console.WriteLine("服务启动成功！");
            await Task.Run(new Action(() =>
            {
                var accept = socket.Accept();

                while (true)
                {
                    var n = accept.ReceiveInt();
                    var n1 = accept.ReceiveLong();
                    var n2 = accept.ReceiveByte();
                    Console.WriteLine($"收到数据:  {n}=={n1}==={n2}");
                } 
            }));
        }
        public static async Task Main(string[] args)
        {
            TestUntils();
            
            Server(); 
            
             
            Socket socket1=new Socket(AddressFamily.InterNetwork, 
                    SocketType.Stream, ProtocolType.Tcp);        
            
            socket1.Connect(IPAddress.Parse("127.0.0.1"),5000);

            Console.WriteLine("链接成功");
            
            socket1.WriteInt(1);
            socket1.WriteLong(2);
            socket1.WriteByte(3);
            socket1.Flush();
            
            
            socket1.WriteInt(4);
            socket1.WriteLong(5);
            socket1.WriteByte(7);
            socket1.Flush();


        }
    }
}