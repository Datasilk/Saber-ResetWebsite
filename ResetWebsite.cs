using System;
using System.IO;
using Saber.Vendor;

namespace Saber.Vendors.ResetWebsite
{
    public class ResetWebsite : Controller, IVendorController
    {
        public override string Render(string body = "")
        {
            if (!CheckSecurity("reset-website")) { return AccessDenied(); }
            var dirs = Core.Website.AllFolders();
            foreach(var dir in dirs)
            {
                try
                {
                    Directory.Delete(dir, true);
                }
                catch (Exception) { }
            }
            var files = Core.Website.AllFiles();
            foreach (var file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception) { }
            }


            Core.Website.CopyTempWebsite();
            return "";
        }
    }
}
