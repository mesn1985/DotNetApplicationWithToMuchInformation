using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreSecurity.RazorSamples.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var outcome = new Random().Next(1, 7);

            Roll = new DiceRoll(outcome);
        }

        public DiceRoll? Roll { get; set; }

        public record DiceRoll(int outcome);
    }
}