#pragma checksum "D:\Project2021\Project2021\BlazorApp1\Pages\Q100.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9152f76be574aee02efe008f408613e6948cbaf"
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
#nullable restore
#line 18 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Q100")]
    public partial class Q100 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><a href=\"Q000\"><span class=\"oi oi-list\" aria-hidden=\"true\"></span></a> - Q100 Location Status Query 库位状态查询</h3>\r\n\r\n<br>\r\n");
            __builder.AddContent(1, 
#nullable restore
#line 7 "D:\Project2021\Project2021\BlazorApp1\Pages\Q100.razor"
 strTable

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n<br>\r\n<img src=\"img/Q100.png\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\Project2021\Project2021\BlazorApp1\Pages\Q100.razor"
       
    MarkupString strTable;



  //  Ten ten;
    protected override void OnInitialized()
    {


        //string jsonString = System.IO.File.ReadAllText(@"D:\Project2021\Project2021\BlazorApp1\wwwroot\json\Q110.json");


        //ten = Newtonsoft.Json.JsonConvert.DeserializeObject<Ten>(jsonString);
        strTable = (MarkupString)Util.GetHtmlStringExt("Q100");


    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
