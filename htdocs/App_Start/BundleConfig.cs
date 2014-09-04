using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;
using System.Web;
using System.Web.Optimization;
using BundleTransformer.Core.Builders;

namespace WebUmbrella_MVC4
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var nullBuilder = new NullBuilder();
            var cssTransformer = new StyleTransformer();
            var jsTransformer = new ScriptTransformer();
            var nullOrderer = new NullOrderer();

            var jquery = new Bundle("~/bundles/jquery", "//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js");
            jquery.Include("~/js/vendor/jquery-1.11.0.min.js");
            jquery.Builder = nullBuilder;
            jquery.Transforms.Add(jsTransformer);
            jquery.Orderer = nullOrderer;
            jquery.CdnFallbackExpression = "window.jquery";

            bundles.Add(jquery);


            var main = new ScriptBundle("~/bundles/main");
            main.Include
            (
                    "~/js/plugins.js",
                    "~/js/main.js"
            );
            main.Builder = nullBuilder;
            main.Transforms.Add(jsTransformer);
            main.Orderer = nullOrderer;

            bundles.Add(main);


            var modernizr = new ScriptBundle("~/bundles/modernizr");
            modernizr.Include
            (
                    "~/js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"
            );
            modernizr.Builder = nullBuilder;
            modernizr.Transforms.Add(jsTransformer);
            modernizr.Orderer = nullOrderer;

            bundles.Add(modernizr);


            var less = new Bundle("~/bundles/less");
            less.Include
            (
                "~/less/normalize.less",
                "~/less/main.less"
            );
            less.Builder = nullBuilder;
            less.Transforms.Add(cssTransformer);
            less.Orderer = nullOrderer;

            bundles.Add(less);
        }
    }
}