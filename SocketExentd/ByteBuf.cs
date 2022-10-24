using System;
using System.Linq;

namespace SocketExentd
{
    public class ByteBuf: IByteBuf
    {
        public int cap { get;  }
        
        private byte[] body;

        private int Writeindex { get; set; }
        private int Readindex { get; set; }

        private ByteBuf(int cap)
        {
            this.cap = cap;
            body = new byte[cap];
        }

     


        /// <summary>
        /// 创建一个指定大小的ByteBuf
        /// </summary>
        /// <param name="cap">最大容量</param>
        /// <returns></returns>
        public static ByteBuf alloc(int cap)
        {
            return new ByteBuf(cap);
        }
        
        public bool PutInt(int value)
        {
            
            var array = bytesUntils.ConvertIntToByteArray(value);
            if (isOutIndex(array.Length,Writeindex))
                return false;
            
            Writeindex= body.PutRange(array,  Writeindex);
            return true;
        }
        
        public bool PutLong(long value)
        {    
            var array = bytesUntils.ConvertLongToByteArray(value);

            if (isOutIndex(array.Length,Writeindex))
                return false;
            
            Writeindex= body.PutRange(array,  Writeindex);
            return true;
        }

        private bool isOutIndex(int len,int index)
        {
            return len + index > body.Length; 
        }

        public bool PutByte(byte val)
        {
            if (isOutIndex(1,Writeindex))
                return false;

            body[Writeindex++] = val;
            return true;
        }

        public bool PutBytes(byte[] bytes)
        {
            if (isOutIndex(bytes.Length,Writeindex))
                return false;

            Writeindex= body.PutRange(bytes,Writeindex);

            return true;
        }

        public byte[] ToBytes()
        {
            return body.Take(Writeindex).ToArray();
        }

        public int getInt()
        {
            
            var range = body.getRange(Readindex,4);
            Readindex += 4;
            return bytesUntils.ConvertByteArrayToInt(range);
        }

        public long getLong()
        {    
            var range = body.getRange(Readindex,8);
            Readindex += 8;
 
            return bytesUntils.ConvertByteArrayToLong(range);        
        }
        
        public int getByte()
        {
            return body[Readindex ++];
        }

        public int capacity()
        {
            return cap;
        }

        public int readerIndex()
        {
            return Readindex;
        }

        public int writerIndex()
        {
            return Writeindex;
        }

        public void resetReaderIndex()
        {
            Readindex = 0;
        }

        public void resetWriteIndex()
        { 
            Writeindex=0;
        }
    }
}