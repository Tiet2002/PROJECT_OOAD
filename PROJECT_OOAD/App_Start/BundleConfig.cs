using System.Web;
using System.Web.Optimization;

namespace PROJECT_OOAD
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)

        { 
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/plugins/jquery").Include(
                        "~/Content/plugins/jquery/jquery.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/plugins/xlsx").Include(
                        "~/Content/plugins/xlsx/xlsx.full.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/plugins/js").Include(
                        "~/Content/plugins/jquery-ui/jquery-ui.js",
                        "~/Content/plugins/bootstrap/js/bootstrap.bundle.js",
                        "~/Content/plugins/chart.js/Chart.js",
                        "~/Content/plugins/sparklines/sparkline.js",
                        "~/Content/plugins/jqvmap/jquery.vmap.js",
                        "~/Content/plugins/jqvmap/maps/jquery.vmap.usa.js",
                        "~/Content/plugins/jquery-knob/jquery.*",
                        "~/Content/plugins/moment/moment.min.js",
                        "~/Content/plugins/daterangepicker/daterangepicker.js",
                        "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.js",
                        "~/Content/plugins/summernote/summernote-bs4.js",
                        "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.js",
                        "~/Content/dist/js/adminlte.js",
                        "~/Content/dist/js/sweetalert2/sweetalert2.js",
                        "~/Content/dist/js/pages/dashboard.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                "~/Content/plugins/datatables/jquery.dataTables.min.js",
                "~/Content/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js",
                "~/Content/plugins/datatables-responsive/js/dataTables.responsive.min.js",
                "~/Content/plugins/datatables-responsive/js/responsive.bootstrap4.min.js",
                "~/Content/plugins/datatables-buttons/js/dataTables.buttons.min.js",
                "~/Content/plugins/datatables-buttons/js/buttons.bootstrap4.min.js",
                "~/Content/plugins/jszip/jszip.min.js",
                "~/Content/plugins/pdfmake/pdfmake.min.js",
                "~/Content/plugins/pdfmake/vfs_fonts.js",
                "~/Content/plugins/datatables-buttons/js/buttons.html5.min.js",
                "~/Content/plugins/datatables-buttons/js/buttons.print.min.js",
                "~/Content/plugins/datatables-buttons/js/buttons.colVis.min.js",
                "~/Content/plugins/daterangepicker/daterangepicker.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/Intranet/js").Include(
                        "~/Content/Intranet/js/footer.js",
                        "~/Content/Intranet/js/notify.js"));

            bundles.Add(new StyleBundle("~/Content/themes/base").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
            
            bundles.Add(new StyleBundle("~/Content/plugins").Include(
                        "~/Content/plugins/fontawesome-free/css/all.css",
                        "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.css",
                        "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.css",
                        "~/Content/plugins/jqvmap/jqvmap.css",
                        "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.css",
                        "~/Content/plugins/daterangepicker/daterangepicker.css",
                        "~/Content/plugins/summernote/summernote-bs4.css",
                        "~/Content/plugins/datatables-responsive/css/responsive.*",
                        "~/Content/plugins/datatables-bs4/css/dataTables.*",
                        "~/Content/plugins/datatables-buttons/css/buttons.*",
                        "~/Content/dist/js/sweetalert2/sweetalert2.css",
                        "~/Content/plugins/daterangepicker/daterangepicker.css"
                        ));
            bundles.Add(new StyleBundle("~/Content/plugins/css").Include(
                        "~/Content/dist/css/adminlte.css",
                        "~/Content/dist/css/custome_color.css"
            ));
        
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Intranet/js/Product").Include(
                    "~/Content/Intranet/js/Product.js"
            ));
            bundles.Add(new StyleBundle("~/Content/Intranet/css/Product").Include(
                     "~/Content/Intranet/css/Product.css"
            ));
        }
    }
}
