using System.Web.Optimization;

namespace DotlessBundling
{
    public class BundleConfig
    {
        public const string JavaScript = "~/bundles/javascript";
        public const string Styles = "~/bundles/styles";

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new LessBundle(Styles).Include("~/Styles/Site.less"));
        }
    }
}