#pragma checksum "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "479cfadb2b54032e8f613d80f468fb2d3a7f29e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"479cfadb2b54032e8f613d80f468fb2d3a7f29e3", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e2989be7935e1a8b5e6466c593fab35ffacecd", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<market.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div  class=\"row my-2 position-static\">\r\n    <p id=\"tempDataMessage\" class=\"position-static\" style=\"color:red\">\r\n         ");
#nullable restore
#line 5 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml"
    Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</div>


<div class=""row my-3"">
    <div class=""col-4"">
        <input type=""text"" class=""form-control text-success"" placeholder=""Search Name/Description..."" onkeyup=""search(this.value)"" />
    </div>
    <div class=""col-2"">
        <a class=""btn btn-primary""");
            BeginWriteAttribute("href", " href=\"", 459, "\"", 498, 1);
#nullable restore
#line 15 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml"
WriteAttributeValue("", 466, Url.Action("Create","Products"), 466, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:10px\">Create Product</a>\r\n    </div>\r\n    <div class=\"col-2\">\r\n        <button class=\"btn btn-warning\"  onclick=\"get()\" style=\"margin-bottom: 10px;\" >Get Products</button>\r\n    </div>\r\n    \r\n</div>\r\n");
            WriteLiteral("\r\n<div class = \"container\">\r\n        <div class=\"row test\"></div>\r\n    </div>\r\n\r\n<div id=\"modal-container\">\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function get() {\r\n            $.ajax({\r\n                url: \'");
#nullable restore
#line 35 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml"
                 Write(Url.Action("GetProducts", "Products"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'GET',
                dataType: 'json',
                beforeSend: function() {
                },
                success: function(response) {
                    if (response.success) {
                        $("".test"").empty();
                        $.each(response.data, (index, item) => {
                            $("".test"").append(` <div class=""col-md-4"">
                                                        <!-- Widget: user widget style 2 -->
                                                        <div class=""card card-widget widget-user-2"" style=""margin-top=20px"">
                                                            <!-- Add the bg color to the header using any of the bg-* classes -->
                                                            <div class=""widget-user-header bg-light"" style=""min-height:140px"" >
                                                             <div class=""float-right"">
                                                  ");
                WriteLiteral(@"                      <button class=""btn btn-light"" onclick=""showModal('${item.id}')""
                                                                                style='font-size:13px;position: relative;top:-12px;'>
                                                                            <i class='fas fa-pen' style='font-size:10px;color:black; position: relative;top:0px;'></i>
                                                                        </button>
                                                             </div>
                                                             <div class=""float-right"">
                                                                       <button class=""btn btn-light"" onclick=""del('${item.id}')""  
                                                                               style='font-size:13px;position: relative;top:-12px'>
                                                                                <i class='fas fa-trash' style='font-size:13px;col");
                WriteLiteral(@"or:black; position: relative;top:0px'></i>
                                                                       </button>
                                                             </div>
                                                             <div class=""float-right"">
                                                                         <button class=""btn btn-light"" onclick=""showDetails('${item.id}')""
                                                                                    style='font-size:13px;position: relative;top:-12px'>
                                                                                <i class='fas fas fa-th' style='font-size:13px;color:black; position: relative;top:0px'></i>
                                                                       </button>
                                                             </div>
                                                                <div class=""widget-user-image"" >
                                        ");
                WriteLiteral(@"                            <img class=""img-circle elevation-2""  
                                                                            src=""/img/${item.image}"" alt=""RUINED""  style=""width:80px; height:80px;border: 3px solid #adb5bd;"">
                                                                </div>
                                                                <!-- /.widget-user-image -->
                                                                <h3 class=""widget-user-desc"" style=""margin-left:10px;""> ${item.name}</h3>
                                                                <h5 class=""widget-user-desc"" style=""margin-left:10px;"">Price:  ${item.price}</h5>
                                                            </div>
                                                            <div class=""card-footer p-0"">
                                                                <ul class=""nav flex-column"">
                 
                                                         ");
                WriteLiteral(@"       </ul>
                                                            </div>
                                                        </div>
                                                        <!-- /.widget-user -->
                                                    </div>                   `)
                        })
                    }
                    else {
                        alert(response.message)
                    }
                },
                error: function(msg) {
                    console.error(msg);
                }
            })
        }
    </script>
    <script>
        function search(val) {
            $.ajax({
                url: '");
#nullable restore
#line 98 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml"
                 Write(Url.Action("Search", "Products"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + '?value=' + val,
                type: 'GET',
                dataType: 'json',
                beforeSend: function () {
                    $('tbody').html('')
                },
                success: function (response) {
                    if (response.success) {
                        $("".test"").empty();
                        $.each(response.data, (index, item) => {
                            $("".test"").append(`<div class=""col-md-4"">
                                                    <!-- Widget: user widget style 2 -->
                                                    <div class=""card card-widget widget-user-2"" style=""margin-top=20px"">
                                                        <!-- Add the bg color to the header using any of the bg-* classes -->
                                                        <div class=""widget-user-header bg-light"" style=""min-height:140px"" >
                                                         <div class=""float-right"">
          ");
                WriteLiteral(@"                                                          <button class=""btn btn-light"" onclick=""showModal('${item.id}')""
                                                                            style='font-size:13px;position: relative;top:-12px;'>
                                                                        <i class='fas fa-pen' style='font-size:10px;color:black; position: relative;top:0px;'></i>
                                                                    </button>
                                                         </div>
                                                         <div class=""float-right"">
                                                                   <button class=""btn btn-light"" onclick=""del('${item.id}')""  
                                                                           style='font-size:13px;position: relative;top:-12px'>
                                                                            <i class='fas fa-trash' style='font-size:13px");
                WriteLiteral(@";color:black; position: relative;top:0px'></i>
                                                                   </button>
                                                         </div>
                                                         <div class=""float-right"">
                                                                     <button class=""btn btn-light"" onclick=""showDetails('${item.id}')""
                                                                                style='font-size:13px;position: relative;top:-12px'>
                                                                            <i class='fas fas fa-th' style='font-size:13px;color:black; position: relative;top:0px'></i>
                                                                   </button>
                                                         </div>
                                                            <div class=""widget-user-image"">
                                                                <img clas");
                WriteLiteral(@"s=""img-circle elevation-2"" src=""/img/${item.image}"" alt=""RUINED""  style=""width:80px; height:80px;border: 3px solid #adb5bd;"">
                                                            </div>
                                                            <!-- /.widget-user-image -->
                                                            <h3 class=""widget-user-username""> ${item.name}</h3>
                                                            <h5 class=""widget-user-desc"">Price:  ${item.price}</h5>
                                                        </div>
                                                        <div class=""card-footer p-0"">
                                                            <ul class=""nav flex-column"">
                 
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <!-- /");
                WriteLiteral(@".widget-user -->
                                                </div>`)
                        })
                    }
                    else {
                        alert(response.message)
                    }
                },
                error: function (msg) {
                    console.error(msg);
                }
            })
        }
    </script>
    <script>
        function showModal(id) {
            $.ajax({
                url: '");
#nullable restore
#line 161 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml"
                 Write(Url.Action("GetModal", "Products"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + ""?id="" + parseInt(id),
                type: 'GET',
                dataType: 'html',
                success: function(response) {
                    $('#modal-container').html(response); 
                    $('.modal').modal('show');
                    $.validator.unobtrusive.parse('form-id');
                    
                },
                error: function(msg) {
                    console.error(msg);
                }
            })
        }
    </script>
     <script>
        function del(id) {
            $.ajax({
                url: '");
#nullable restore
#line 179 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml"
                 Write(Url.Action("Delete", "Products"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + ""?id="" + parseInt(id),
                type: 'GET',
                dataType: 'html',
                success: function(response) {
                    $('#modal-container').html(response); 
                    $('.modal').modal('show');
                    $.validator.unobtrusive.parse('form-id');
                    
                },
                error: function(msg) {
                    console.error(msg);
                }
            })
        }
    </script>

    <script>
        setTimeout(function () {
            document.getElementById('tempDataMessage').innerHTML='';
        }, 3000); // 3000 milliseconds = 3 sec
    </script>

             <script>
  
        function mysubmit(e)
        {
            e.preventDefault();
                
                var Name = document.getElementById('Name').value;
                var Description = document.getElementById('Description').value;
                var Price = document.getElementById('Price').value;
        ");
                WriteLiteral(@"        var Image = document.getElementById('Image').value;
                var Quantity = document.getElementById('Quantity').value;
                var AlertQuantity = document.getElementById('AlertQuantity').value;
                var Id = document.getElementById('Id').value;
                let obj = {
                    ""Name"": Name,
                    ""Id"":Id,
                    ""Description"":Description,
                    ""Price"":Price,
                    ""Image"":Image,
                    ""Quantity"":Quantity,
                    ""AlertQuantity"":AlertQuantity
                            };
                    $.ajax({
                        url: '/Products/Edit',
                        type: 'POST',
                        contentType: ""application/x-www-form-urlencoded; charset=UTF-8"",
                        data:{product: obj} ,
                        success: function (response) {
                            if (response.success) {
                                window");
                WriteLiteral(@".location.href = '/Products/Index';
                            } else {
                                $('#error').text('');

                                for (var fieldName in response.errors) {
                                var errorMessage = response.errors[fieldName];
                                $(""#error"").append(errorMessage + '<br>');
}

                            }
                        },
                        error: function () {
                            alert('An error occurred during the AJAX request.');
                        }
                    })
        }
   
    </script>
    <script>
        function showDetails(id) {
            $.ajax({
                url: '");
#nullable restore
#line 251 "E:\HIAST\4th_year\web_development\marketDB 7\marketDB 7\New folder (2)\web\Views\Products\Index.cshtml"
                 Write(Url.Action("GetDetails", "Products"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + ""?id="" + parseInt(id),
                type: 'GET',
                dataType: 'html',
                success: function(response) {
                    $('#modal-container').html(response); 
                    $('.modal').modal('show');
                    $.validator.unobtrusive.parse('form-id');
                    
                },
                error: function(msg) {
                    console.error(msg);
                }
            })
        }
    </script>    
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<market.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591