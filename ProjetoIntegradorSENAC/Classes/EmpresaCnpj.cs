using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.Classes
{
    internal class EmpresaCnpj
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }

        private static readonly HttpClient client = new HttpClient();

        public async Task<EmpresaCnpj?> ConsultarCnpj(string cnpj)
        {
            try
            {
                cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

                string url = $"https://www.receitaws.com.br/v1/cnpj/{cnpj}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                        return null;

                    string json = await response.Content.ReadAsStringAsync();
                    var root = JsonDocument.Parse(json).RootElement;

                    return new EmpresaCnpj
                    {
                        NomeFantasia = root.GetProperty("fantasia").GetString(),
                        RazaoSocial = root.GetProperty("nome").GetString(),
                        Email = root.GetProperty("email").GetString(),
                        Telefone = root.GetProperty("telefone").GetString(),
                        Cep = root.GetProperty("cep").GetString(),
                        Bairro = root.GetProperty("bairro").GetString(),
                        Municipio = root.GetProperty("municipio").GetString(),
                    };
                }
            }
            catch
            {
                return null;
            }
        }
     
    }
}