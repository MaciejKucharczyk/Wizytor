using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Wizytor.Pages
{
    public class AppointmentsModel : PageModel
    {
        private readonly ILogger<AppointmentsModel> _logger;

        public AppointmentsModel(ILogger<AppointmentsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
