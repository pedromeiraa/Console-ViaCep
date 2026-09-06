# Console-ViaCep

Aplicação em C# para consultar endereços brasileiros via API do ViaCEP.

## Descrição

Este projeto é um console app que solicita um CEP ao usuário, faz uma requisição HTTP para a API do ViaCEP e exibe alguns dados do endereço retornado, como:

- CEP
- Logradouro
- Cidade

## Requisitos

- .NET SDK 10.0 ou superior
- Internet para acessar a API do ViaCEP

## Como executar

1. Abra o terminal na raiz do projeto.
2. Execute:

```bash
dotnet run --project ConsumerViaCep/ConsumerViaCep.csproj
```

3. Digite o CEP desejado quando solicitado.

## Estrutura do projeto

```text
ViaCep/
├── ConsumerViaCep/
│   ├── ConsumerViaCep.csproj
│   ├── Endereco.cs
│   └── Program.cs
├── README.md
└── .gitignore
```

## Exemplo de uso

```text
Digite o CEP para consulta: 
01001000

Realizando requisição para o endpoint: https://viacep.com.br/ws/01001000/json/...
CEP: 01001-000
Rua: Avenida Paulista
Cidade: São Paulo
```

## Observação

A API do ViaCEP retorna um JSON com dados do endereço. A aplicação usa `System.Text.Json` para desserializar esses dados em uma classe `Endereco`.