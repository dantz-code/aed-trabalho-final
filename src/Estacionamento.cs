#nullable enable
using System;

public class Estacionamento
{
    private const int Capacidade = 8;
    private const int TarifaPorHora = 12;

    private Veiculo? Inicio;
    private Veiculo? Fim;
    private int quantidadeDeCarros = 0;

    public bool Entrar(string placa, string nome, string marca)
    {
        if (quantidadeDeCarros < Capacidade)
        {
            var novo = new Veiculo(placa, nome, marca);
            InserirNoFim(novo);
            return true;
        }

        return false;
    }

    private void InserirNoFim(Veiculo veiculo)
    {
        veiculo.Prox = null;

        if (Fim == null)
        {
            Inicio = veiculo;
            Fim = veiculo;
        }
        else
        {
            Fim.Prox = veiculo;
            Fim = veiculo;
        }

        quantidadeDeCarros++;
    }

    public bool RetirarPorPlaca(string placaSolicitada)
    {
        for (int tentativa = 0; tentativa < quantidadeDeCarros; tentativa++)
        {
            if (VerificarPrimeiroEManobrar(placaSolicitada))
            {
                return true;
            }
        }

        return false;
    }

    private bool VerificarPrimeiroEManobrar(string placaSolicitada)
    {
        if (Inicio == null)
        {
            return false;
        }

        // Guarda o primeiro carro antes de avançar o início da fila.
        var retirado = Inicio;
        Inicio = retirado.Prox;

        if (Inicio == null)
        {
            Fim = null;
        }

        retirado.Prox = null;
        quantidadeDeCarros--;

        if (placaSolicitada == retirado.Placa)
        {
            var horaSaida = DateTime.Now;
            retirado.HoraSaida = horaSaida;

            var tempoNoPatio = horaSaida - retirado.HoraEntrada;
            var horasCobradas = Math.Ceiling(tempoNoPatio.TotalHours);
            var valorTotal = horasCobradas * TarifaPorHora;

            Console.WriteLine($"Placa: {retirado.Placa}");
            Console.WriteLine($"Horas cobradas: {horasCobradas}");
            Console.WriteLine($"Valor a pagar: R$ {valorTotal:F2}");

            return true;
        }

        // Na manobra, o mesmo veículo volta com a hora de entrada original.
        InserirNoFim(retirado);
        return false;
    }

    public void ListarVeiculos()
    {
        var atual = Inicio;

        if (atual == null )
        {
            Console.WriteLine("Estacionamento vazio");
        }

        while ( atual != null)
        {
            Console.WriteLine(atual.Placa);
            atual = atual.Prox;
        }
    }
}