#pragma checksum "D:\Project2021\Project2021\BlazorApp1\Pages\HomeHead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1cedd6b4e9254a8032f1343d702ac3d1413c9c1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class HomeHead : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddMarkupContent(1, "<a href=\"/\"><span class=\"oi oi-home\" aria-hidden=\"true\"></span></a> - ");
            __builder.AddMarkupContent(2, "<a href=\"PageList\"><span class=\"oi oi-list\" aria-hidden=\"true\"></span></a> -");
            __builder.AddContent(3, 
#nullable restore
#line 2 "D:\Project2021\Project2021\BlazorApp1\Pages\HomeHead.razor"
                                                                                                                                                             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "D:\Project2021\Project2021\BlazorApp1\Pages\HomeHead.razor"
       
    [Parameter]
    public string Title { get; set; }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
