using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Smartphone nokia =
    new Nokia(numero: "1234-5677", modelo: "Nokia 171", imei: "1337", memoria: 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");

Console.WriteLine("\n");

Console.WriteLine("iPhone: ");
Smartphone iPhone =
    new IPhone(numero: "1234-5666", modelo: "iPhone 2", imei: "6789", memoria: 64);

iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Facebook");