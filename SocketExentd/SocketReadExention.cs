using System.Net.Sockets;
using SocketExentd;

namespace Comon.SocketChanle
{
    public static class SocketReadExention
    {
        private static int ReadIndex = 0;
        
        /// <summary>
        /// 读取一个int
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
        public static int ReceiveInt(this Socket socket)
        {
            var bytes = new byte[4];
            socket.Receive(bytes);
            
            ReadIndex += 4;
            return bytesUntils.ConvertByteArrayToInt(bytes);
        }
            
        public static long ReceiveLong(this Socket socket)
        {
            var longByte = new byte[8];
            socket.Receive(longByte);
            return bytesUntils.ConvertByteArrayToLong(longByte);
        }
        
        public static int getReadIndex(this Socket socket)
        {
            return ReadIndex;
        }
        
        /**
         * 读取一个字节
         */
        public static byte ReceiveByte(this Socket socket)
        {
            var bytes = new byte[1];
            socket.Receive(bytes);
            ReadIndex += 1;
            return bytes[0];
        }

        /**
         * 读取指定长度
         */
        public static ByteBuf ReceiveBytes(this Socket socket, int len)
        {
            var bytes = new byte[len];

            socket.Receive(bytes);


            var byteBuf = ByteBuf.alloc(len);
            
            byteBuf.PutBytes(bytes);
            
            return byteBuf;
        }
        
        
        
        
        
        
    }
}