#pragma checksum "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7af477fdb181895c842b81e8377ea4000bd905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Welcome_Index), @"mvc.1.0.view", @"/Views/Welcome/Index.cshtml")]
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
#line 1 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\_ViewImports.cshtml"
using ASPNETCOREMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\_ViewImports.cshtml"
using ASPNETCOREMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7af477fdb181895c842b81e8377ea4000bd905", @"/Views/Welcome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a78727764f6c6a989b69cc3a4f5c8e1d91b161e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Welcome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
  
    ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>Hello from the view template</p>\r\n<p>");
#nullable restore
#line 8 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 9 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
Write(ViewBag.Greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
  
    var a = 10;
    var b = 20;
    var sum = a + b;
    var text = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>The sum of ");
#nullable restore
#line 17 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
         Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and ");
#nullable restore
#line 17 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
                Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is ");
#nullable restore
#line 17 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
                      Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
 if (sum >= 20)
{
    text = "Yes";
}else{
    text = "No";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>The Text is ");
#nullable restore
#line 25 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
          Write(text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
  
    List<string> names = new List<string>() {"AAA", "BBBB", "CCC"};

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 32 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
     foreach (var name in names)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 34 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
       Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 35 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<ol>\r\n");
#nullable restore
#line 39 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
     for (int i = 0; i < names.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <li>\r\n           ");
#nullable restore
#line 42 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
      Write(names[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </li>  \r\n");
#nullable restore
#line 44 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
     for (int i = names.Count - 1; i >= 0 ; i--)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <li>\r\n           ");
#nullable restore
#line 49 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
      Write(names[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </li>  \r\n");
#nullable restore
#line 51 "C:\Users\dell\Desktop\C-Sharp-Beginner-to-Advance\ASPNETCOREMVC\Views\Welcome\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</ol>");
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
