using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartBreadcrumbs.Attributes;

namespace RazorPagesAndMvc.Pages.Lnd
{
    [Breadcrumb("Details", FromPage = typeof(IndexModel))]
    public class DetailsModel : PageModel
    {
        public void OnGet()
        {
            
        }
    }
}