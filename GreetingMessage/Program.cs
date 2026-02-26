using System;

Console.WriteLine("=== 인사 테스트 ===");

Console.WriteLine("[격식체]");
Formal.Message message1 = new Formal.Message();
message1.SayHello("홍길동");
message1.SayBye("홍길동");

Console.WriteLine("\n[비격식체]");
Casual.Message message2 = new Casual.Message();
message2.SayHello("철수");
message2.SayBye("철수");