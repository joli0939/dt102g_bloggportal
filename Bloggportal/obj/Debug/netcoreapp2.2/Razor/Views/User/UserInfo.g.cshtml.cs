#pragma checksum "C:\Users\admin\source\repos\Bloggportal\Bloggportal\Views\User\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f23057d089763f185fb3ce1541015c0297911fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserInfo), @"mvc.1.0.view", @"/Views/User/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserInfo.cshtml", typeof(AspNetCore.Views_User_UserInfo))]
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
#line 1 "C:\Users\admin\source\repos\Bloggportal\Bloggportal\Views\_ViewImports.cshtml"
using Bloggportal;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\Bloggportal\Bloggportal\Views\_ViewImports.cshtml"
using Bloggportal.Models;

#line default
#line hidden
#line 1 "C:\Users\admin\source\repos\Bloggportal\Bloggportal\Views\User\UserInfo.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23057d089763f185fb3ce1541015c0297911fd5", @"/Views/User/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7427b7c40847dbd70e4c766f91d4718ae51e96c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\source\repos\Bloggportal\Bloggportal\Views\User\UserInfo.cshtml"
  
    ViewData["Title"] = "UserInfo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 41, true);
            WriteLiteral("\r\n<h1>UserInfo</h1>\r\n\r\n<h2>Användarnamn: ");
            EndContext();
            BeginContext(171, 18, false);
#line 9 "C:\Users\admin\source\repos\Bloggportal\Bloggportal\Views\User\UserInfo.cshtml"
             Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(189, 17, true);
            WriteLiteral("</h2>\r\n\r\n<h2>Id: ");
            EndContext();
            BeginContext(207, 10, false);
#line 11 "C:\Users\admin\source\repos\Bloggportal\Bloggportal\Views\User\UserInfo.cshtml"
   Write(ViewBag.Id);

#line default
#line hidden
            EndContext();
            BeginContext(217, 5, true);
            WriteLiteral("</h2>");
            EndContext();
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