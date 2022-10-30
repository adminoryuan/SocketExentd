namespace SocketExentd
{
    public interface IByteBuf
    {

        /// <summary>
        /// 添加一个Long类型数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
         bool PutLong(long value);
         
        /// <summary>
        /// 添加一个byte类型数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
         bool PutByte(byte val);
        
        /// <summary>
        /// 添加一个byte[]类型数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
         bool PutBytes(byte[] bytes);

            /// <summary>
            /// 添加一个Double类型数据
            /// </summary>
            /// <param name="bolVal"></param>
            /// <returns></returns>
         bool PutDouble(double bolVal);

        double getDouble();
         
         
         /// <summary>
         /// 获得byte数组
         /// </summary>
         /// <returns></returns>
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