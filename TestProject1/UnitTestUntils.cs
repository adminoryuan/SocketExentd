using System;
using NUnit.Framework;
using SocketExentd;

namespace TestProject1
{
    public class UnitTestUntils
    { 
        [Test]
        public static void TestUntils()
        {
            for (int i = 0; i < 100000; i++)
            {    
                var convertByteArrayToInt = bytesUntils.ConvertIntToByteArray(i);

                var ToInt = bytesUntils.ConvertByteArrayToInt(convertByteArrayToInt);

               Assert.True(ToInt==i);

            }

            for (long i = 0; i < 100000; i++)
            {
                           
                var bytes = bytesUntils.ConvertLongToByteArray(i);

                var ToLong = bytesUntils.ConvertByteArrayToLong(bytes);

                Assert.True(ToLong==i);
            }
        }
        
    }
}