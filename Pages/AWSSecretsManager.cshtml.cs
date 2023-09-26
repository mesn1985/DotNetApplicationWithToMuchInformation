using Amazon;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreSecurity.RazorSamples.Pages
{
    public class AWSSecretsManagerModel : PageModel
    {
        public string ApiToken = string.Empty;

        public void OnGet()
        {
            string secretName = "AspNetCoreSecurityAWS";
            string region = "us-east-2";

            var client = new AmazonSecretsManagerClient(RegionEndpoint.GetBySystemName(region));

            var request = new GetSecretValueRequest()
            {
                SecretId = secretName
            };

            var response = client.GetSecretValueAsync(request).Result;
            ApiToken = response?.SecretString ?? string.Empty;
        }
    }
}
