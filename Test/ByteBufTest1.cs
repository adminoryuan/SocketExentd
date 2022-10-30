using System;
using NUnit.Framework;
using SocketExentd;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var byteBuf = ByteBuf.alloc(10240);

            for (int i = 0; i < 2000; i++)
            {
                byteBuf.PutInt(i);

                Assert.True(byteBuf.getInt() == i);

            }

            var index = byteBuf.readerIndex();
            byteBuf.resetWriteIndex();
            byteBuf.resetReaderIndex();

            for (byte i = 0; i < byte.MaxValue; i++)
            {

                byteBuf.PutByte(i);
                

                Assert.True(byteBuf.getByte() == i);


            }
            byteBuf.resetWriteIndex();
            byteBuf.resetReaderIndex();
            
            for (long i = 0; i < 1000; i++)
            {
                byteBuf.PutLong(i);

                Assert.True(byteBuf.getLong() == i);

            }
            
            byteBuf.resetWriteIndex();
            byteBuf.resetReaderIndex();
            
            for (long i = 0; i < 1000; i++)
            {
                byteBuf.PutDouble(i*1.0);

                Assert.True(byteBuf.getDouble() == i*1.0);

            }

        }
        
        
    }
}