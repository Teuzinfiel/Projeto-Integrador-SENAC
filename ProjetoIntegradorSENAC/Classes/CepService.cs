using ProjetoIntegradorSENAC.personalizado;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class CepService
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public async Task<CepService?> BuscarCepAsync(string cep)
    {
        try
        {
            // Remove tudo que não for número
            cep = new string(cep.Where(char.IsDigit).ToArray());

            if (cep.Length != 8)
            {
                var opa = new caixaMensagem("CEP inválido.", "Falha ❌");
                opa.ShowDialog();
            }

            string url = $"https://viacep.com.br/ws/{cep}/json/";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                var opa = new caixaMensagem("Erro ao consultar CEP.", "Falha ❌");
                opa.ShowDialog();
            }

            var json = await response.Content.ReadAsStringAsync();

            var resultado = JsonSerializer.Deserialize<CepService>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            if (resultado?.Erro == true)
            {
                var opa = new caixaMensagem("CEP não encontrado.", "Falha ❌");
                opa.ShowDialog();
            }

            return resultado;
        }
        catch (Exception ex)
        {
            var opa = new caixaMensagem("Erro: " + ex.Message, "Falha ❌");
            opa.ShowDialog();
            return null;
        }
    }

    // 🔹 Propriedades retornadas pela API
    public string? Cep { get; set; }
    public string? Logradouro { get; set; }
    public string? Bairro { get; set; }
    public string? Localidade { get; set; } // Município
    public string? Uf { get; set; }
    public bool? Erro { get; set; }
}
