namespace DesafioPOO.Models
{
    // Classe Nokia que herda de Smartphone
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Outras inicializações específicas do Nokia, se necessário
        }

        // Sobrescreve o método "InstalarAplicativo" da classe abstrata
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Nokia.");
        }
    }

}