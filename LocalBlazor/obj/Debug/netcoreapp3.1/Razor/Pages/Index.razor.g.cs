#pragma checksum "D:\Project2021\LocalBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d295a61aa8377193badb4fbf9715efe7df855d9"
// <auto-generated/>
#pragma warning disable 1591
namespace LocalBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project2021\LocalBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project2021\LocalBlazor\_Imports.razor"
using LocalBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project2021\LocalBlazor\_Imports.razor"
using LocalBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Project2021\LocalBlazor\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 4 "D:\Project2021\LocalBlazor\Pages\Index.razor"
     Localizer["Hello World"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "h2");
            __builder.AddContent(4, 
#nullable restore
#line 5 "D:\Project2021\LocalBlazor\Pages\Index.razor"
     DateTime.Now.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "h2");
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\Project2021\LocalBlazor\Pages\Index.razor"
     DateTime.Now.ToLongDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<LocalBlazor.Shared.SurveyPrompt>(9);
            __builder.AddAttribute(10, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> Localizer { get; set; }
    }
}
#pragma warning restore 1591