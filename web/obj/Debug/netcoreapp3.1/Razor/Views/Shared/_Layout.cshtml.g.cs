#pragma checksum "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63cbf1b8543bd002f3bd648350db3db7b9661e1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\_ViewImports.cshtml"
using web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\_ViewImports.cshtml"
using web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63cbf1b8543bd002f3bd648350db3db7b9661e1e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e2989be7935e1a8b5e6466c593fab35ffacecd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Suppliers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductEntries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63cbf1b8543bd002f3bd648350db3db7b9661e1e6314", async() => {
                WriteLiteral("\r\n\t<meta charset=\"utf-8\" />\r\n\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n\t<title>");
#nullable restore
#line 7 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Point Of Sale
		
	</title>
	<link rel=""icon"" href=""/favicon2.ico"">


	<!-- Google Font: Source Sans Pro -->
	<link rel=""stylesheet""
		href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
	<!-- Font Awesome -->
	<link rel=""stylesheet"" href=""/plugins/fontawesome-free/css/all.min.css"">
	<!-- Ionicons -->
	<link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
	<!-- Tempusdominus Bootstrap 4 -->
	<link rel=""stylesheet"" href=""/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"">
	<!-- iCheck -->
	<link rel=""stylesheet"" href=""/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
	<!-- JQVMap -->
	<link rel=""stylesheet"" href=""/plugins/jqvmap/jqvmap.min.css"">
	<!-- Theme style -->
	<link rel=""stylesheet"" href=""/dist/css/adminlte.min.css"">
	<!-- overlayScrollbars -->
	<link rel=""stylesheet"" href=""/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
	<!-- Daterange picker -->
	<l");
                WriteLiteral(@"ink rel=""stylesheet"" href=""/plugins/daterangepicker/daterangepicker.css"">
	<!-- summernote -->
	<link rel=""stylesheet"" href=""/plugins/summernote/summernote-bs4.min.css"">
	<style>

		

			/*.content-wrapper {
				   min-height:100vh;
				   margin:0;
				   background-image: repeating-linear-gradient(155deg,
					  #696969   ,   #000000 100px,
					  #000000 100px, #696969 105px, 
					   #000000 105px, #000000 130px,
					  #696969  130px, #DCDCDC 270px,
					  #DCDCDC 270px, #DCDCDC 275px,
					  #DCDCDC  275px, #696969  280px,
					  #DCDCDC 280px, #DCDCDC 330px
				      );
			}*/


			
		.content-wrapper {
		   background: url(/p21.jpg);
           background-size: cover;
           background-repeat: no-repeat;
           background-attachment: fixed;
			}
	
	</style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63cbf1b8543bd002f3bd648350db3db7b9661e1e9578", async() => {
                WriteLiteral("\r\n\t<div class=\"wrapper\">\r\n\r\n\t\t<!-- Navbar -->\r\n\t\t<nav class=\"main-header navbar navbar-expand navbar-white navbar-light\">\r\n\t\t\t<!-- Left navbar links -->\r\n\t\t\t<ul class=\"navbar-nav\">\r\n");
                WriteLiteral(@"				<li class=""nav-item d-none d-sm-inline-block"">
					<a  class=""nav-link"" href= ""/Home""><b>Home</b></a>
				</li>
			</ul>

		</nav>

		<!-- Main Sidebar Container -->
		<aside class=""main-sidebar sidebar-dark-primary elevation-4"">
			<!-- Brand Logo -->
			<a  class=""brand-link"">
				<img src=""/pos1.png"" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3""
					style=""opacity: .8"">
				<span class=""brand-text font-weight-light"">Point Of Sale</span>
			</a>

			<!-- Sidebar -->
			<div class=""sidebar"">
				<!-- Sidebar Menu -->
				<nav class=""mt-2"">
					<ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu""
						data-accordion=""false"">
						<!-- Add icons to the links using the .nav-icon class
                        with font-awesome or any other icon font library -->

						<li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63cbf1b8543bd002f3bd648350db3db7b9661e1e11025", async() => {
                    WriteLiteral(@"
                                <i class=""nav-item fas fa-apple-alt"" style='font-size:18px;color:#	DCDCDC;margin-left:3px'></i>
                                <p style=""margin-left:7px"">
                                    Products
                                </p>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                         <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63cbf1b8543bd002f3bd648350db3db7b9661e1e13170", async() => {
                    WriteLiteral(@"
                                <i class=""nav-item fas fa-users"" style='font-size:15px;color:#	DCDCDC;margin-left:3px'></i>
                                <p style=""margin-left:7px"">
                                    Customers
                                </p>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63cbf1b8543bd002f3bd648350db3db7b9661e1e15311", async() => {
                    WriteLiteral(@"
                                <i class=""nav-item fas fa-shopping-cart"" style='font-size:18px;color:#DCDCDC;margin-left:3px'></i>
                                <p style=""margin-left:7px"">
                                    Orders
                                </p>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63cbf1b8543bd002f3bd648350db3db7b9661e1e17456", async() => {
                    WriteLiteral(@"
                                <i class=""nav-item fas fa-truck-moving"" style='font-size:18px;color:#DCDCDC;margin-left:3px'></i>
                                <p style=""margin-left:7px"">
                                    Suppliers
                                </p>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63cbf1b8543bd002f3bd648350db3db7b9661e1e19603", async() => {
                    WriteLiteral(@"
                                <i class=""nav-item fas fa-truck-loading"" style='font-size:18px;color:#	DCDCDC;margin-left:3px'></i>
                                <p style=""margin-left:7px"">
                                    Product entries
                                </p>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
						
					</ul>
				</nav>
				<!-- /.sidebar-menu -->
			</div>
			<!-- /.sidebar -->
		</aside>

		<div class=""content-wrapper"">
			<!-- Content Header (Page header) -->
			<div class=""content-header"">
				<div class=""container-fluid"">
					<div class=""row mb-2"">
						<div class=""col-sm-6"">
							<h1 class=""m-0"" style=""color:white"">
								");
#nullable restore
#line 154 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Shared\_Layout.cshtml"
                           Write(ViewContext.RouteData.Values["controller"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1> 
						</div><!-- /.col -->
						<div class=""col-sm-6"">
							<ol class=""breadcrumb float-sm-right"">
								<li class=""breadcrumb-item"" ><a href=""#"" style=""color:white"">Home</a></li>
								<li class=""breadcrumb-item active"" style=""color:white"">
									");
#nullable restore
#line 160 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Shared\_Layout.cshtml"
                               Write(ViewContext.RouteData.Values["controller"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t</ol>\r\n\t\t\t\t\t\t</div><!-- /.col -->\r\n\t\t\t\t\t</div><!-- /.row -->\r\n\t\t\t\t</div><!-- /.container-fluid -->\r\n\t\t\t</div>\r\n\t\t\t<!-- /.content-header -->\r\n\t\t\t<main role=\"main\" class=\"content\">\r\n\t\t\t\t<div class=\"container-fluid\">\r\n\t\t\t\t\t");
#nullable restore
#line 170 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</main>\r\n\t\t</div>\r\n\t\t<!-- /.content-wrapper -->\r\n");
                WriteLiteral(@"
		<!-- Control Sidebar -->
		<aside class=""control-sidebar control-sidebar-dark"">
			<!-- Control sidebar content goes here -->
		</aside>
		<!-- /.control-sidebar -->

	</div>


	<!-- jQuery -->
	<script src=""/plugins/jquery/jquery.min.js""></script>
	<!-- jQuery UI 1.11.4 -->
	<script src=""/plugins/jquery-ui/jquery-ui.min.js""></script>
	<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
	<script>
		$.widget.bridge('uibutton', $.ui.button)
	</script>
	<!-- Bootstrap 4 -->
	<script src=""/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
	<!-- ChartJS -->
	<script src=""/plugins/chart.js/Chart.min.js""></script>
	<!-- Sparkline -->
	<script src=""/plugins/sparklines/sparkline.js""></script>
	<!-- JQVMap -->
	<script src=""/plugins/jqvmap/jquery.vmap.min.js""></script>
	<script src=""/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
	<!-- jQuery Knob Chart -->
	<script src=""/plugins/jquery-knob/jquery.knob.min.js""></script>
	<!-- daterangepicker -->
	<script src=");
                WriteLiteral(@"""/plugins/moment/moment.min.js""></script>
	<script src=""/plugins/daterangepicker/daterangepicker.js""></script>
	<!-- Tempusdominus Bootstrap 4 -->
	<script src=""/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
	<!-- Summernote -->
	<script src=""/plugins/summernote/summernote-bs4.min.js""></script>
	<!-- overlayScrollbars -->
	<script src=""/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
	<!-- AdminLTE App -->
	<script src=""/dist/js/adminlte.js""></script>
");
                WriteLiteral("\t<!-- AdminLTE dashboard demo (This is only for demo purposes) -->\r\n\t<script src=\"/dist/js/pages/dashboard.js\"></script>\r\n\t\r\n\t");
#nullable restore
#line 227 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591