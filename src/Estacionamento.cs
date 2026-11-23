#nullable enable
using System;

public class Estacionamento
{
    private const int Capacidade = 8;

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

}
