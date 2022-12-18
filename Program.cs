using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphoneX = new Iphone("559999999", "X", "555", 32);

iphoneX.Ligar();
iphoneX.ReceberLigacao();
iphoneX.InstalarAplicativo("WhatsApp");

Nokia NokiaG21 = new Nokia("5512312312", "G21", "556", 32);

NokiaG21.Ligar();
NokiaG21.ReceberLigacao();
NokiaG21.InstalarAplicativo("WhatsApp");
