using IdentityServer4.Models;

namespace AuthServer
{
    static public class Config
    {
        #region Scopes
        //API'larda kullanılacak izinleri tanımlar.
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
        {
            new ApiScope("AtiBackend.Write","ati yazma izni"),
            new ApiScope("AtiBackend.Read","ati okuma izni"),

        };
        }
        #endregion
        #region Resources
        //API'lar tanımlanır.
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
        {
            new ApiResource("AtiBackend"){ Scopes = { "AtiBackend.Write", "AtiBackend.Read" } },
        };
        }
        #endregion
        #region Clients
        //API'ları kullanacak client'lar tanımlanır.    
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
        {
            new Client
                    {
                        ClientId = "61",
                        ClientName = "AtiBackend",
                        ClientSecrets = { new Secret("ati".Sha256()) },
                        AllowedGrantTypes = { GrantType.ClientCredentials },
                        AllowedScopes = { "AtiBackend.Write", "AtiBackend.Read" }
                    },

        };
        }
        #endregion
    }
}
