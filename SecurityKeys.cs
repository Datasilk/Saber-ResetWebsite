using Saber.Core;
using Saber.Vendor;

namespace Saber.Vendors.ResetWebsite
{
    public class SecurityKeys : IVendorKeys
    {
        public string Vendor { get; set; } = "Reset Website";
        public SecurityKey[] Keys { get; set; } = new SecurityKey[]
        {
            new SecurityKey(){Value = "reset-website", Label = "Reset Website", Description = "Able to replace the current website with the default template website"},
        };
    }
}
