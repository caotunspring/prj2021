#pragma checksum "D:\Project2021\Project2021\WebApp2Lang\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae3be05584009191a21d25e356bb8f77dddcd7ba"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp2Lang.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using WebApp2Lang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project2021\Project2021\WebApp2Lang\_Imports.razor"
using WebApp2Lang.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-tohqdfttti");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-tohqdfttti");
            __builder.OpenComponent<WebApp2Lang.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-tohqdfttti");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-tohqdfttti");
            __builder.AddMarkupContent(14, "<span class=\"pr-2\" b-tohqdfttti>Site Language </span>");
            __builder.OpenComponent<WebApp2Lang.Shared.ChooseLanguage>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-tohqdfttti>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "content px-4");
            __builder.AddAttribute(21, "b-tohqdfttti");
            __builder.AddContent(22, 
#nullable restore
#line 15 "D:\Project2021\Project2021\WebApp2Lang\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
