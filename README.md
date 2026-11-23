# Estruturas de Dados — Trabalho Final

Projeto em C# de um estacionamento com capacidade para 8 veículos.

## Organização

```text
aed-trabalho-final/
├── docs/
│   └── enunciado.md
├── src/
│   ├── Main.cs
│   ├── Estacionamento.cs
│   └── Veiculo.cs
├── Estrutura de Dados - Trabalho Final.csproj
├── .gitignore
└── README.md
```

- [Enunciado completo](docs/enunciado.md): requisitos do trabalho.
- [Main.cs](src/Main.cs): ponto de entrada e menu do console para estacionar, listar e retirar veículos.
- [Estacionamento.cs](src/Estacionamento.cs): entrada, retirada, cobrança e listagem de veículos.
- [Veiculo.cs](src/Veiculo.cs): dados do veículo e referência para o próximo veículo.

## Desenvolvimento

O projeto utiliza o SDK do .NET 10. Abra o arquivo `.csproj` na sua IDE ou, nesta pasta, execute:

```bash
dotnet build "Estrutura de Dados - Trabalho Final.csproj"
```

Para abrir o menu do programa, execute:

```bash
dotnet run --project "Estrutura de Dados - Trabalho Final.csproj"
```

Os arquivos C# de `src/` são incluídos automaticamente pelo projeto.

As pastas `bin/` e `obj/` são geradas pelo .NET e estão no `.gitignore`.
