#pragma checksum "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6b0c6abdf29e54fed906ad5141f4930dd22551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6b0c6abdf29e54fed906ad5141f4930dd22551", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b7318a9bd111c44b50cc28b4ef55f72694f262", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenleme Sayfası</h1>\r\n");
#nullable restore
#line 8 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumbnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbNailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 29 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
