using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Testando Nokia ===");
        Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Nokia 3310", imei: "111111111111111", memoria: 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n=== Testando iPhone ===");
        Smartphone iphone = new Iphone(numero: "11988888888", modelo: "iPhone 14 Pro", imei: "222222222222222", memoria: 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
