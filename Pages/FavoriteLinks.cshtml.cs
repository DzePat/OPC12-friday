using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OPC12_friday.Pages
{
    public class FavoriteLinksModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public FavoriteLinksModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
