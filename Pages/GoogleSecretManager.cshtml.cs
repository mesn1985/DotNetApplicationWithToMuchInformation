using Google.Cloud.SecretManager.V1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreSecurity.RazorSamples.Pages
{
    public class GoogleSecretManagerModel : PageModel
    {
        public string ApiToken = string.Empty;

        public void OnGet()
        {
            var smsClient = SecretManagerServiceClient.Create();

            var secretVersionName = new SecretVersionName(
                "projectId",
                "secretId",
                "secretVersionId");

            var result = smsClient.AccessSecretVersion(secretVersionName);

            ApiToken = result.Payload.Data.ToStringUtf8();
        }
    }
}
