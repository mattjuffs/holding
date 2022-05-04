using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Holding
{
    public class IndexModel : PageModel
    {
        public string Domain { get; set; }

        public void OnGet()
        {
            var host = HttpContext.Request.Host.Host;
            this.Domain = host.ToString();
        }
    }
}
