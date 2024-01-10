using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o tipo de smartphone (Nokia ou iPhone):");
        string tipoSmartphone = Console.ReadLine();

        Smartphone smartphone;

        Console.WriteLine("Digite o número:");
        string numero = Console.ReadLine();

        Console.WriteLine("Digite o modelo:");
        string modelo = Console.ReadLine();

        Console.WriteLine("Digite o IMEI:");
        string imei = Console.ReadLine();

        Console.WriteLine("Digite a memória:");
        int memoria;
        while (!int.TryParse(Console.ReadLine(), out memoria) || memoria <= 0)
        {
            Console.WriteLine("Memória inválida. Informe novamente:");
        }

        if (tipoSmartphone.ToLower() == "nokia")
        {
            smartphone = new Nokia(numero, modelo, imei, memoria);
        }
        else if (tipoSmartphone.ToLower() == "iphone")
        {
            smartphone = new Iphone(numero, modelo, imei, memoria);
        }
        else
        {
            Console.WriteLine("Tipo de smartphone inválido.");
            return;
        }

        smartphone.Ligar();
        smartphone.ReceberLigacao();

        Console.WriteLine("Digite o nome do aplicativo para instalar:");
        string nomeApp = Console.ReadLine();

        smartphone.InstalarAplicativo(nomeApp);

        Console.ReadLine();
    }
}
