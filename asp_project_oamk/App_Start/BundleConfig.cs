using System.Web;
using System.Web.Optimization;

namespace asp_project_oamk
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Static/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Static/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Static/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Static/Scripts/bootstrap.js",
                      "~/Static/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Static/Content/css").Include(
                      "~/Static/Content/bootstrap.css",
                      "~/Static/Content/site.css"));
        }
    }
}
