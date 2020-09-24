using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;

namespace RazorPagesAndMvc.Pages.Lnd
{
    //[Breadcrumb("Add Invoice", FromPage = typeof(DetailsModel))]
    public class AddInvoice : PageModel
    {
        public void OnGet()
        {
            var breadcrumbNode = new RazorPageBreadcrumbNode("/Lnd/AddInvoice", "Add Invoice")
            {
                Parent = new RazorPageBreadcrumbNode("/Lnd/Details", "Details")
                {
                    Parent = new RazorPageBreadcrumbNode("/Lnd", "Nodes")
                }
            };
            ViewData["BreadcrumbNode"] = breadcrumbNode;
        }
    }
}