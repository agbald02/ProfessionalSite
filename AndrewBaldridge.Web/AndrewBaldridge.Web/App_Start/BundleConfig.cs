using System.Web.Optimization;

namespace AndrewBaldridge.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
#endif
            bundles.Add(new StyleBundle("~/bundles/commoncss")
                .Include("~/Content/Styles.css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme-css")
                );

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs",
                "//maxcdn.bootstrapcdn.comm/bootstrap/3.3.1/js/bootstrap.min/js")
                .Include("~/Scripts/bootstrap.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/commonjavascript")
            .Include("~/Scripts/bootstrap.js")
            .Include("~/Scripts/jquery-2.1.4.js")
            .Include("~/Scripts/unslider.min.js.js")
            );

            BundleTable.EnableOptimizations = true;
        }
    }
}