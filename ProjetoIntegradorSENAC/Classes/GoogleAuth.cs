using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.Classes
{
    internal class GoogleAuth
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string[] _scopes = { "openid", "email", "profile" };

        public GoogleAuth(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public async Task<(string Id, string Email, string Name, string Foto)> CadastrarAsync()
        {
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = _clientId,
                    ClientSecret = _clientSecret
                },
                _scopes,
                Guid.NewGuid().ToString(),
                CancellationToken.None,
                new FileDataStore("TokenGoogleCadastro", true)
            );

            var settings = new GoogleJsonWebSignature.ValidationSettings
            {
                Audience = new[] { _clientId },

                // aceita clock skew +/- 10 minutos
                IssuedAtClockTolerance = TimeSpan.FromMinutes(10),
                ExpirationTimeClockTolerance = TimeSpan.FromMinutes(10)
            };

            var payload = await GoogleJsonWebSignature.ValidateAsync(credential.Token.IdToken!, settings);

            return (payload.Subject!, payload.Email!, payload.Name!, payload.Picture!);
        }

        public async Task<string> LoginAsync()
        {
            var dataStore = new FileDataStore("TokenGoogleLogin", true);

            // remove token antigo
            await dataStore.ClearAsync();

            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = _clientId,
                    ClientSecret = _clientSecret
                },
                _scopes,
                "user",
                CancellationToken.None,
                dataStore
            );

            var settings = new GoogleJsonWebSignature.ValidationSettings
            {
                Audience = new[] { _clientId },
                IssuedAtClockTolerance = TimeSpan.FromMinutes(10),
                ExpirationTimeClockTolerance = TimeSpan.FromMinutes(10)
            };

            var payload = await GoogleJsonWebSignature.ValidateAsync(
                credential.Token.IdToken!,
                settings
            );

            return payload.Email!;
        }
    }
}
