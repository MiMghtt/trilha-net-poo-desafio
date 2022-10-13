using DesafioPOO.Models;
Console.WriteLine("\n");

Console.Write("Smartphone Nokia");
Smartphone nokia = new Nokia("11 11111 1111", "Lumia", "11111111", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.Write("Smartphone Iphone");
Smartphone iphone = new Iphone("22 22222 2222", "14 PRO MAX", "2222222222", 126);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp business");

Console.WriteLine("\n");
