using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Gevcorst.WebU1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/*.css"));
            bundles.Add(new StyleBundle("~/Content/jqueryui")
   .Include("~/Content/themes/base/all.css"));
            

            bundles.Add(new ScriptBundle("~/bundles/gevcorstscripts").Include("~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                
                "~/Scripts/jquery.unobtrusive-ajax.js",
                "~/Scripts/bootstrap-datepicker.js",
                "~/Scripts/bootstrap-datepicker.min.js",
                "~/Scripts/datePickerReady.js"
             
               ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui")
   .Include("~/Scripts/jquery-ui-{version}.js"));

        }
    }
}