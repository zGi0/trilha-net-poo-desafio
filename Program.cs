using DesafioPOO.Models;

// testando objeto Iphone
Console.WriteLine("Testando Iphone\n");
Iphone celularIphone = new Iphone("219999999", "XD-931", 43242, 32);
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Youtube");

Console.WriteLine("\n\n");

// testando objeto Nokia
Console.WriteLine("Testando Nokia\n");
Nokia celNokia = new Nokia("21996666", "OX-832", 789221, 64);
celNokia.ReceberLigacao();
celNokia.InstalarAplicativo("Instagram");