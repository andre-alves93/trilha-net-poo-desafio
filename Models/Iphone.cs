namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Outras inicializações específicas do iPhone, se necessário
        }

        // Sobrescreve o método "InstalarAplicativo" da classe abstrata
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um iPhone.");
        }
    }
}