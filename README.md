# SharpSocketExentd
  - # 为什么需要它？
  - 当我们使用socket编写网络应用时,我们无法直接读取一个int byte long 等基础类型。SharpSocketExentd 对此进行了扩展。
  
  - # 如何使用？
  -  nuget 安装 ``` SocketExentd ```
  - # Example
  - 完整example 查看 [example](https://github.com/adminoryuan/SharpSocketExentd/blob/master/TestExentd/Example.cs)
  
  
  - 接收数据
  ``` c# 
            var n = accept.ReceiveInt();
            var n1 = accept.ReceiveLong();
            var n2 = accept.ReceiveByte();
  ```
  - 发送数据
  ```c#
            socket1.WriteInt(1);
            socket1.WriteLong(2);
            socket1.WriteByte(3);
            socket1.Flush();
            
            
            socket1.WriteInt(4);
            socket1.WriteLong(5);
            socket1.WriteByte(7);
            socket1.Flush();
  ```
  - 一次发送
  ``` c#
             socket1.WriteByteAndFlush(1);
            socket1.WriteLongAndFlush(1);
  ```

    
