#pragma checksum "D:\Project2021\Project2021\BlazorApp1\Pages\Q080.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23888d9f0637c324d65d9ed87842ad862865d5ad"
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
#nullable restore
#line 18 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Blazorise.TreeView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project2021\Project2021\BlazorApp1\Pages\Q080.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project2021\Project2021\BlazorApp1\Pages\Q080.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Q080")]
    public partial class Q080 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorApp1.Pages.Q000Head>(0);
            __builder.AddAttribute(1, "Title", "Q080 Inventory Data Query库存数据查询");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.AddContent(3, 
#nullable restore
#line 6 "D:\Project2021\Project2021\BlazorApp1\Pages\Q080.razor"
 strHtml

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Project2021\Project2021\BlazorApp1\Pages\Q080.razor"
       
    MarkupString strHtml;

    protected override void OnInitialized()
    {
        var wwwroot = WebEnvironment.WebRootPath;
    
        strHtml = (MarkupString)Util.GetHtmlStringExtAll(wwwroot, "Q080");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment WebEnvironment { get; set; }
    }
}
#pragma warning restore 1591
