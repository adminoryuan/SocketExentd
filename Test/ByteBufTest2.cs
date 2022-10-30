using NUnit.Framework;
using SocketExentd;

namespace TestProject1
{
    public class untilsTest2
    {
        [Test]

        public void Test()
        {
            var byteBuf = ByteBuf.alloc(1024);
            
            byteBuf.PutByte(1);
            byteBuf.PutByte(2);
            byteBuf.PutByte(3);

            byteBuf.PutDouble(4);

            byteBuf.PutInt(5);
            byteBuf.PutInt(6);
            byteBuf.PutInt(7);

            byteBuf.PutLong(8);


            Assert.True(byteBuf.getByte()==1);
            Assert.True(byteBuf.getByte()==2);
            Assert.True(byteBuf.getByte()==3);
            
            
            Assert.True(byteBuf.getDouble()==4);
            
            Assert.True(byteBuf.getInt()==5);
            Assert.True(byteBuf.getInt()==6);
            Assert.True(byteBuf.getInt()==7);
            
        }
        
    }
}