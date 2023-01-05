using Saber.Vendor;

namespace Saber.Vendors.ResetWebsite
{
    public class Info : IVendorInfo
    {
        public string Key { get; set; } = "ResetWebsite";
        public string Name { get; set; } = "Reset Website";
        public string Description { get; set; } = "Allows administrators to reset their current website to the default template website.";
        public string Icon { get; set; }
        public Vendor.Version Version { get; set; } = "1.0.0.0";
    }
}
