using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Comon;

namespace SocketExentd
{
    public static class SocketWriteExention
    {
         
         
        
        public static  bool WriteIntAndFlush(this Socket socket,int value)
        {
            var convertIntToByteArray = BitConverter.GetBytes(value);

            socket.Send(convertIntToByteArray);

            return true;
        }
        
        
        

        public static bool WriteLongAndFlush(this Socket socket,int value)
        {
            var convertIntToByteArray = BitConverter.GetBytes(value);

            socket.Send(convertIntToByteArray);

            return true;
        }

       
        
        public static bool WriteByteAndFlush(this Socket socket, byte val)
        {
            
            socket.Send(new byte[]{val});

            return true;
            
        }
         
        
        public static bool WriteByteAndFlush(this Socket socket, byte[] val)
        {
             
            return socket.Send(val)!=-1;
            
        }

        public static bool Write(this Socket socket, IByteBuf buf)
        {
            var bytes = buf.ToBytes();
            socket.Send(bytes);

            return true;
        }

      
    }
}