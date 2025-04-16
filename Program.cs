using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("(31)92924922", "Nokia", "G10G123", 256);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Duolingo");

Console.WriteLine("");

Iphone i1 = new Iphone("(11)91524215", "Iphone 13", "APPLE13ADQ115", 512);

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Discord");