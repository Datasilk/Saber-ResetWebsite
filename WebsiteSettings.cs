using Saber.Core;
using Saber.Vendor;

namespace Saber.Vendors.ResetWebsite
{
    public class WebsiteSettings : IVendorWebsiteSettings
    {
        public string Name { get; set; } = "Reset Website";
        public string Render(IRequest request)
        {
            var settingsView = new View("/Vendors/ResetWebsite/resetwebsite.html");
            request.AddScript("/editor/vendors/resetwebsite/resetwebsite.js");
            return settingsView.Render();
        }
    }
}