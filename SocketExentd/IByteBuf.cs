namespace SocketExentd
{
    public interface IByteBuf
    {

         bool PutLong(long value);
         
         bool PutByte(byte val);
         bool PutBytes(byte[] bytes);

         byte[] ToBytes();

         int getInt();
        
         long getLong();
        
         int getByte();
         
         int capacity();

         int readerIndex();
         
         int writerIndex();

         void resetReaderIndex();
         
         void resetWriteIndex();
    }    
    


}