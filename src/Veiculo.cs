public class Veiculo
{
    public string Placa { get; }
    public string Nome { get; }
    public string Marca { get; }
    public DateTime HoraEntrada { get; }
    public DateTime? HoraSaida { get; set; }

    public Veiculo? Prox { get; set; }

    public Veiculo(string placa, string nome, string marca)
    {
        Placa = placa;
        Nome = nome;
        Marca = marca;
        HoraEntrada = DateTime.Now;
    }
}