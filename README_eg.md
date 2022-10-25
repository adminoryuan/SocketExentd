# SharpSocketExentd ![c#](https://img.shields.io/badge/c%23-8.0-red) ![netstandard2.1](https://img.shields.io/badge/netstandard-2.1-blue)
  - # [中文](https://github.com/adminoryuan/SharpSocketExentd/blob/master/README.md)
  
  - # Why do I need it？
  - When we use sockets to write network applications, we cannot directly read an int byte long and other basic types. '` ` SharpSocketExited' ` ` extends this. We can easily solve the problem of package sticking and unpacking with the help of '` ` SocketExited' '.
  
  - # How to use？
  -  nuget install  ```SocketExentd ```
  - ``` dotnet add package SocketExentd --version 1.0.1 ```
  - # Example
  - complete example  [example](https://github.com/adminoryuan/SharpSocketExentd/blob/master/TestExentd/Example.cs)
  
  - receive..
  ``` c# 
            var n = accept.ReceiveInt();
            var n1 = accept.ReceiveLong();
            var n2 = accept.ReceiveByte();
  ```
  - socket send byte..
  ```c#
           var byteBuf = ByteBuf.alloc(1024);
            
            byteBuf.PutInt(1);
            byteBuf.PutLong(2);

            byteBuf.PutByte(3);

            
           socket1.Write(byteBuf);
           
            socket1.WriteByteAndFlush(1);
            socket1.WriteLongAndFlush(1);
  ```
  - # bytebuf
  - create bytebuf
  ``` c#
    var byteBuf = ByteBuf.alloc(1024);
  ```
  - resetwriteIndex or resetReaderIndex
  ```c#
      byteBuf.resetWriteIndex();
      byteBuf.resetReaderIndex();
  ```
  - add data or get data 
  ```c#
      byteBuf.PutInt(i);
      
      byteBuf.PutByte(i);
      
      byteBuf.PutLong(i);
      
      byteBuf.getInt();
      
      byteBuf.getLong()
      
      byteBuf.getByte();
      
      
  ```
    

