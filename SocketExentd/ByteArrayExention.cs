using System;

namespace SocketExentd
{
    public static class ByteArrayExention
    {
        public static int PutRange(this byte[] bytes,byte[] val, int index)
        {
            if (val.Length+index>bytes.Length)
            {
                throw new Exception("索引超出了界限");
            }

            int i ;
            for (i = 0; i <val.Length; i++)
            {
                bytes[index+i] = val[i];
            }

            return index+i;
        }
        
        public static byte[] getRange(this byte[] bytes,int startindex,int len)
        {
            if (startindex+len>bytes.Length)
            {
                throw new Exception("索引超出了界限");
            }

            byte[] body=new byte[len];
            int i = 0;

            while (i<len)
            {
                body[i] = bytes[startindex + i++];
            }

            return body;
        }
    }
}