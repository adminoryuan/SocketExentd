using System;

namespace Comon
{
   public class bytesUntils
    {
        /// <summary>
        /// 把int32类型的数据转存到4个字节的byte数组中
        /// </summary>
        /// <param name="m">int32类型的数据
        /// <param name="arry">4个字节大小的byte数组
        public static byte[] ConvertIntToByteArray(Int32 m)
        {
            byte[] arry=new byte[4];;
            arry[0] = (byte)(m & 0xFF);
            arry[1] = (byte)((m & 0xFF00) >> 8);
            arry[2] = (byte)((m & 0xFF0000) >> 16);
            arry[3] = (byte)((m >> 24) & 0xFF);
            return arry;
        }

        /// <summary>
        /// 把byte数组中的前4个字节转换为int32类型的数据
        /// </summary>
        public static int ConvertByteArrayToInt(byte[] arry)
        {
            return BitConverter.ToInt32(arry, 0);
        }



        public static byte[] ConvertLongToByteArray(long val)
        {
                int index = 0;
                byte[] body=new byte[8];
                body[index++] = (byte)val;
                body[index++] = (byte)(val >> 8);
                body[index++] = (byte)(val >> 0x10);
                body[index++] = (byte)(val >> 0x18);
                body[index++] = (byte)(val >> 0x20);
                body[index++] = (byte)(val >> 40);
                body[index++] = (byte)(val >> 0x30);
                body[index] = (byte)(val >> 0x38);

                return body;

        }
        
        public static long ConvertByteArrayToLong(byte[] arry)
        {
            return BitConverter.ToInt64(arry);
        }

    }
}