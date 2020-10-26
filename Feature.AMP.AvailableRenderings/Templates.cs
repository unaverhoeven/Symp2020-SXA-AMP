using Sitecore.Data;
using System.Runtime.InteropServices;

namespace Feature.AMP.AvailableRenderings
{
    public static class Templates
    {
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct AvailableAMPRenderings
        {
            ///sitecore/templates/Feature/AMP Renderings/Available AMP Renderings
            public static readonly ID ID = ID.Parse("{1D5C2F8A-0DE8-409C-A3EB-37DA43E9D6BE}");

            [StructLayout(LayoutKind.Sequential, Size = 1)]
            public struct Fields
            {
            }
        }
    }
}