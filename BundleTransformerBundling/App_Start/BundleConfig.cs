using System.Web.Optimization;
using BundleTransformer.Core.Transformers;

namespace BundleTransformerBundling
{
    public class BundleConfig
    {
        public const string JavaScript = "~/bundles/javascript";
        public const string Styles = "~/bundles/styles";

        public static void RegisterBundles(BundleCollection bundles)
        {
            var stylesBundle = new Bundle(Styles);
            stylesBundle.Include("~/Styles/Site.less");
            stylesBundle.Transforms.Add(new CssTransformer());
            stylesBundle.Transforms.Add(new CssMinify());

            bundles.Add(stylesBundle);
        }
    }
}