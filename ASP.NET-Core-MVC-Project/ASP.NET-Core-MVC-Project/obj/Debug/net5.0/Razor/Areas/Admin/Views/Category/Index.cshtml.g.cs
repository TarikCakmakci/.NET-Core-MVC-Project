#pragma checksum "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a794ebcd124c963292e4551090acc0c233fcb564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a794ebcd124c963292e4551090acc0c233fcb564", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminTemplate/js/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a794ebcd124c963292e4551090acc0c233fcb5643908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $('$DeleteBtn').click(function () {
        swal({
            title: ""Good job!"",
            text: ""You clicked the button!"",
            icon: ""success"",
            button: ""Aww yiss!"",
        });
    })
</script>
<h1>Index</h1>
<br />

<h1>Kategori Listesi</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Kategori Adı</th>
        <th>Pasif Yap</th>
        <th>Aktif Yap</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 32 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 35 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 898, "\"", 953, 3);
            WriteAttributeValue("", 905, "/Admin/Category/CategoryDelete/", 905, 31, true);
#nullable restore
#line 37 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 936, item.CategoryId, 936, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 952, "/", 952, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"DeleteBtn\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\" class=\"btn btn-danger\">Pasif Yap</a></td>\r\n");
            WriteLiteral("            <td><a href=\"#\" class=\"btn btn-success\">Aktif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory\" class=\"btn btn-primary\">Yeni Kategori Ekle</a>\r\n<br /><br />\r\n\r\n");
#nullable restore
#line 47 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new {page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
