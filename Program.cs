using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main()
    {
        // Teste com a classe Iphone
        Iphone iphone = new Iphone("123456789");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        // Teste com a classe Nokia
        Nokia nokia = new Nokia("987654321");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");

    }
}