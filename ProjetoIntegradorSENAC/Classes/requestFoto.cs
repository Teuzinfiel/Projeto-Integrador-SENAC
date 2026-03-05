using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.Classes
{
    internal class requestFoto
    {
        private readonly HttpClient _httpClient;

        public requestFoto()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.sophia-me13.site/erpex/");
        }

        public async Task<(bool Sucesso, string Resposta)> UploadFotoProdutoAsync(
     string caminhoArquivo,
     string codigoFoto)
        {
            using var form = new MultipartFormDataContent();

            // Envia código da foto (string)
            form.Add(new StringContent(codigoFoto), "codigo");

            // Envia arquivo se existir
            if (!string.IsNullOrWhiteSpace(caminhoArquivo) && File.Exists(caminhoArquivo))
            {
                var bytes = await File.ReadAllBytesAsync(caminhoArquivo);
                var fileContent = new ByteArrayContent(bytes);

                fileContent.Headers.ContentType =
                    new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                form.Add(fileContent, "foto", Path.GetFileName(caminhoArquivo));
            }

            var response = await _httpClient.PostAsync("upload.php", form);
            var responseContent = await response.Content.ReadAsStringAsync();

            return (response.IsSuccessStatusCode, responseContent);
        }
    }
 }

