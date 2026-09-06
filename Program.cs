using static System.Console;
using System.Text.Json;
using ConsumerViaCep;

WriteLine("Digite o CEP para consulta: ");
var cep = ReadLine();

var enderecoUrl = $"https://viacep.com.br/ws/{cep}/json/";

WriteLine($"Realizando requisição para o endpoint: {enderecoUrl}...");

var client = new HttpClient();

try
{
    HttpResponseMessage response = await client.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respondeApi = await response.Content.ReadAsStringAsync();

    Endereco? enderecoRetorandoDaApi = JsonSerializer.Deserialize<Endereco>(respondeApi);
    WriteLine($"CEP: {enderecoRetorandoDaApi?.Cep}");
    WriteLine($"Rua: {enderecoRetorandoDaApi?.Logradouro}");
    WriteLine($"Cidade: {enderecoRetorandoDaApi?.Localidade}");
}
catch (HttpRequestException e)
{
    WriteLine("Erro: " + e.InnerException);
    WriteLine("Mensagem: " + e.Message);
}