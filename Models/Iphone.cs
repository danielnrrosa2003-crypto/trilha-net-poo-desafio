namespace DesafioPOO.Models
{
    // A classe Iphone herda da classe abstrata Smartphone
    public class Iphone : Smartphone
    {
        // Construtor — repassa os parâmetros para o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o método abstrato da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone...");
        }
    }
}
