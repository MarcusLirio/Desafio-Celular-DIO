using DesafioPOO.Models;

Smartphone nokia = new Nokia("22223333", "k30", "45646546545", "64");
Smartphone iphone = new Iphone("55554444", "13 PRO", "454455645646", "128");
Smartphone xiaomi = new Xiaomi("1111199999", "11 Ultra PRO", "SD545465452", "254");

nokia.Numero = "21 1111-3333";
iphone.Numero = "22 4444-5555";
xiaomi.Numero = "23 7777-9999";

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("FaceBook");

Console.WriteLine();

xiaomi.Ligar();
xiaomi.ReceberLigacao();
xiaomi.InstalarAplicativo("Instagran");

