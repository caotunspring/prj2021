// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "D:\Project2021\Project2021\BlazorApp1\Pages\Q000 - Copy.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project2021\Project2021\BlazorApp1\Pages\Q000 - Copy.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project2021\Project2021\BlazorApp1\Pages\Q000 - Copy.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CleanLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Q000/{id?}")]
    public partial class Q000___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Project2021\Project2021\BlazorApp1\Pages\Q000 - Copy.razor"
       
    [Parameter]
    public string Id { get; set; }

    public string PageTitle { get; set; }


    public List<IdName> PageList;

    public string NO_PARAMETER = "LIST";
    public string StrId { get; set; }

    MarkupString strHtml;
    protected override void OnInitialized()
    {



    }
    protected override void OnAfterRender(bool firstRender)
    {
        var x = Id;

        if (Id != null)
        {
            StrId = Id;
        }
        else
        {
            StrId = null;
        }
        StateHasChanged();
        var wwwroot = WebEnvironment.WebRootPath;

        //            strHtml = (MarkupString)Util.GetHtmlStringExtAll(wwwroot, "Q080");
        strHtml = (MarkupString)Util.GetHtmlStringExtAll(wwwroot, StrId);

        //        PageTitle = Util.GetPageTitle(wwwroot, StrId);
        PageTitle = pageService.GetPageTitle(StrId);
        PageList = pageService.GetPageList("Q");




    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PageService pageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment WebEnvironment { get; set; }
    }
}
#pragma warning restore 1591
