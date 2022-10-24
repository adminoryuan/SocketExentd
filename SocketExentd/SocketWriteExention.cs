using System.Collections.Generic;
using System.Net.Sockets;
using Comon;

namespace SocketExentd
{
    public static class SocketWriteExention
    {
        private static List<byte[]> cache=new List<byte[]>();
        
        public static bool WriteInt(this Socket socket,int value)
        {
            var convertIntToByteArray = bytesUntils.ConvertIntToByteArray(value);
            
            cache.Add(convertIntToByteArray);

            return true;
        }
        
        public static  bool WriteAndFlush(this Socket socket,int value)
        {
            var convertIntToByteArray = bytesUntils.ConvertIntToByteArray(value);

            socket.Send(convertIntToByteArray);

            return true;
        }
        
        
        public static bool WriteLong(this Socket socket,long value)
        {
            var convertIntToByteArray = bytesUntils.ConvertLongToByteArray(value);
            
            cache.Add(convertIntToByteArray);

            return true;
        }

        public static bool WriteLongAndFlush(this Socket socket,int value)
        {
            var convertIntToByteArray = bytesUntils.ConvertIntToByteArray(value);

            socket.Send(convertIntToByteArray);

            return true;
        }

        public static bool WriteByte(this Socket socket, byte val)
        {
            
            cache.Add(new byte[]{val});
            
            
            return true;
            
        }
        
        public static bool WriteByteAndFlush(this Socket socket, byte val)
        {
            
            socket.Send(new byte[]{val});

            return true;
            
        }
        
        
        public static bool WriteBytes(this Socket socket, byte[] val)
        {
            
            cache.Add(val);
            
            
            return true;
            
        }
        
        public static bool WriteByteAndFlush(this Socket socket, byte[] val)
        {
             
            return socket.Send(val)!=-1;
            
        }

        public static bool Flush(this Socket socket)
        {
            foreach (var bytes in cache)
            {
                socket.Send(bytes);
            }
            cache=new List<byte[]>();

            return true;
        }
    }
}