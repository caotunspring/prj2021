#pragma checksum "D:\Project2021\Project2021\BlazorApp1\Pages\Conf.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "341a87a0c16e7d0ec07d7d85efa5b189af6ad9dc"
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
#nullable restore
#line 19 "D:\Project2021\Project2021\BlazorApp1\_Imports.razor"
using Blazorise.TreeView;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/conf")]
    public partial class Conf : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>項目討論</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h4>TBD</h4>\r\n\r\n");
            __builder.OpenElement(2, "ul");
            __builder.OpenElement(3, "li");
            __builder.AddMarkupContent(4, "\r\n        建議設定 milestone\r\n\r\n    \r\n        ");
            __builder.OpenComponent<Blazorise.Table>(5);
            __builder.AddAttribute(6, "class", "gridtable");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "<tr><th></th><th>主題</th><th>程式系列|補充說明</th><th>筆數</th><th>完成日期</th></tr>\r\n            ");
                __builder2.AddMarkupContent(9, "<tr><th>1</th><td>基本框架, 使用者介面, 和所有查詢報表</td><td>Q000数据查询(12) R000报表(6) </td><td align=\"right\">18&nbsp;&nbsp; </td><td align=\"center\">2021-03-31</td></tr>\r\n            ");
                __builder2.AddMarkupContent(10, "<tr><th>2</th><td>涉及數據增刪改,上下(ERP/MES|WCS)啣接</td><td>P000流程执行(7)  M000数据维护(2) C000库存盘点(3) </td><td align=\"right\">12&nbsp;&nbsp; </td><td align=\"center\">2021-04-30</td></tr>\r\n            ");
                __builder2.AddMarkupContent(11, "<tr><th>3</th><td>用戶權限,多語,小型顯示設備(安卓手持)</td><td>S000系统设定(9) </td><td align=\"right\">9&nbsp;&nbsp; </td><td align=\"center\">2021-05-31</td></tr>\r\n            ");
                __builder2.AddMarkupContent(12, "<tr><th>4</th><td>保固</td><td>N/A </td><td></td><td align=\"center\">TBD</td></tr>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<li>\r\n        真正施工時, 上述 123實際是會重疊實現\r\n    </li>\r\n    ");
            __builder.AddMarkupContent(15, "<li>\r\n        實際進度,建議單週或雙週,\r\n        由PM,儘可能會同盟立接收單位或指派人員 review,\r\n        可以即時適當調整\r\n    </li>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<hr>\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(17, "<h4>2021-03-03</h4>\r\n");
            __builder.AddMarkupContent(18, @"<ul><li>
        何時確認項目是否立案進行
        <ul><li>【Kaiping】盟立預算不高, 如果價格談得攏就會立刻立案</li></ul></li>
    <li>
        是否有保密協議及其範圍
        <ul><li>【Kaiping】立案後盟立會提供目前程式可運行的版本含DB與source code, 如果需要額外NDA就會簽</li></ul></li>
    <li>
        是否有現成測試用例含現成可用數據
        <ul><li>【Kaiping】同上, 盟立可以提供現在運行的版本來參考</li></ul></li>

    <li>
        向上(ERP|MES)及向下(AS/RS)的溝通協議    <ul><li>【Kaiping】 ERP和WCS的接口比照目前的版本, 如果需要修改可以另外談</li></ul></li>
    <li>
        是否有其它現有技術文檔
        <ul><li>【Kaiping】盟立可安排原本的SA/SD人員當面說明, 如果有文檔會可提供</li></ul></li>

    <li>
        多語要求及標準
        <ul><li>【Kaiping】提供簡中+英語, 並開放客戶自行維護泰語resource檔</li></ul></li>


    <li>
        驗收標準
        <ul><li>【Kaiping】完成測試後提交安裝手冊, 使用手冊 , 測試報告及程式碼給盟立驗收, 並提供1年期的保固</li></ul></li></ul>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
