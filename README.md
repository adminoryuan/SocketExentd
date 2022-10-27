# SharpSocketExentd ![c#](https://img.shields.io/badge/c%23-8.0-red) ![netstandard2.1](https://img.shields.io/badge/netstandard-2.1-blue) ![Mit](https://img.shields.io/badge/Mit-Passing-yellow) 
  
  - [English](https://github.com/adminoryuan/SharpSocketExentd/blob/master/README_eg.md)
  - # 为什么需要它？
  - 当我们使用socket编写网络应用时,我们无法直接读取一个int byte long 等基础类型,```SharpSocketExentd``` 对此进行了扩展,我们可以借助```SocketExentd```来轻松解决粘包 拆包问题。
  
  - # 如何使用？
  -  nuget 安装  ```SocketExentd ```
  - ``` dotnet add package SocketExentd --version 1.0.1 ```
  - # Example
  - 完整example 查看 [example]( https://github.com/adminoryuan/SharpSocketExentd/blob/master/Example/Example.cs)
  - 完整单元测试 查看 [Test]( https://github.com/adminoryuan/SocketExentd/tree/master/TestProject1)
  - 接收数据
  ``` c# 
            var n = accept.ReceiveInt();
            var n1 = accept.ReceiveLong();
            var n2 = accept.ReceiveByte();
  ```
  - 发送数据
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
  - 获得bytebuf
  ``` c#
    var byteBuf = ByteBuf.alloc(1024);
  ```
  - 重置读写指针
  ```c#
      byteBuf.resetWriteIndex();
      byteBuf.resetReaderIndex();
  ```
  - 添加数据获得数据
  ```c#
      byteBuf.PutInt(i);
      
      byteBuf.PutByte(i);
      
      byteBuf.PutLong(i);
      
      byteBuf.getInt();
      
      byteBuf.getByte();
      byteBuf.getLong();
      
      
      
  ```
    
