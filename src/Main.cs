using System;

public class Program
{
    public static void Main()
    {
        var estacionamento = new Estacionamento();
        string? opcao;

        do
        {
            Console.WriteLine("1 - Estacionar");
            Console.WriteLine("2 - Listar veículos");
            Console.WriteLine("3 - Retirar veículo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Placa: ");
                    var placa = Console.ReadLine();

                    Console.Write("Nome: ");
                    var nome = Console.ReadLine();

                    Console.Write("Marca: ");
                    var marca = Console.ReadLine();

                    if (placa == null || nome == null || marca == null)
                    {
                        Console.WriteLine("Faltam dados do veículo.");
                        break;
                    }

                    bool entrou = estacionamento.Entrar(placa, nome, marca);

                    if (entrou)
                    {
                        Console.WriteLine("Veículo estacionado.");
                    }
                    else
                    {
                        Console.WriteLine("Estacionamento lotado.");
                    }
                    break;

                case "2":
                    estacionamento.ListarVeiculos();
                    break;

                case "3":
                    Console.Write("Placa do veículo que vai sair: ");
                    var placaSaida = Console.ReadLine();

                    if (placaSaida == null)
                    {
                        break;
                    }

                    bool saiu = estacionamento.RetirarPorPlaca(placaSaida);

                    if (saiu == false)
                    {
                        Console.WriteLine("Placa não encontrada.");
                    }
                    break;
            }
        } while (opcao != "0" && opcao != null);
    }
}