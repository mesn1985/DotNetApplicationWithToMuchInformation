using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreSecurity.RazorSamples.Pages
{
    public class SecretManagerCodeBehindModel : PageModel
    {
        private readonly IConfiguration Configuration;

        public SecretManagerCodeBehindModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string ApiToken = string.Empty;

        public void OnGet()
        {
            ApiToken = Configuration["Shop:ApiToken"];
        }
    }
}
