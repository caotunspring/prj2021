#pragma checksum "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a323aa7818be585cae9de9e903925fba2d4ca79"
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
#line 5 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CleanLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/doc/{id?}")]
    public partial class Doc : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
 if (@StrId == null)
{



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3><a href=\"/\"><span class=\"oi oi-home\" aria-hidden=\"true\"></span></a> -  <span class=\"oi oi-list\" aria-hidden=\"true\"></span> Doc List 文檔列表 </h3>\r\n    ");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 17 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
         if (@PageList != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
             foreach (var item in @PageList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", "/doc/" + (
#nullable restore
#line 21 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
                                   item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, 
#nullable restore
#line 21 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
                                               item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
             

        }

        

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 46 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
}
else
{

    

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 51 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
     strHtml

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 51 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
            
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Project2021\Project2021\BlazorApp1\Pages\Doc.razor"
       
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
        PageList = pageService.GetPageList();




    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PageService pageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment WebEnvironment { get; set; }
    }
}
#pragma warning restore 1591
