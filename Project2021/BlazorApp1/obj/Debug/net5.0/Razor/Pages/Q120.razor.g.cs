#pragma checksum "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f358e65db8bbe061d8cb14b91c8463c759effe59"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Q120")]
    public partial class Q120 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><a href=\"Q000\"><span class=\"oi oi-list\" aria-hidden=\"true\"></span></a> - Q120 Posting Change Transfer Query库存属性移转查询</h3>\r\n\r\n\r\n\r\n\r\n<br>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddContent(2, 
#nullable restore
#line 14 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
     strTable

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n    <hr>\r\n\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "gridtable");
            __builder.AddAttribute(6, "width", "75%");
            __builder.AddMarkupContent(7, "<tr><th></th><th width=\"13%\">Topic 主題</th><th>Description 說明</th></tr>\r\n        ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "<th>1</th>\r\n            ");
            __builder.AddMarkupContent(10, "<td>\r\n                作业目的<br>\r\n                Operation purpose\r\n            </td>\r\n            ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 26 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "<th>2</th>\r\n            ");
            __builder.AddMarkupContent(16, "<td>\r\n                说明<br>\r\n                Description\r\n            </td>\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 36 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "<th>3</th>\r\n            ");
            __builder.AddMarkupContent(22, "<td>\r\n                角色<br>\r\n                Roles\r\n            </td>\r\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 46 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th>4</th>\r\n            ");
            __builder.AddMarkupContent(28, "<td>\r\n                前置条件<br>\r\n                Precondition\r\n\r\n            </td>\r\n            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 59 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item4

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n        ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "<th>5</th>\r\n            ");
            __builder.AddMarkupContent(34, "<td>\r\n                输入<br>\r\n                Input\r\n\r\n            </td>\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 71 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item5

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n        ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "<th>6</th>\r\n            ");
            __builder.AddMarkupContent(40, "<td>\r\n                输出<br>\r\n                Output\r\n\r\n            </td>\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 84 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item6

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n        ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "<th>7</th>\r\n            ");
            __builder.AddMarkupContent(46, "<td>\r\n                异常处里<br>\r\n                Abnormal handle\r\n            </td>\r\n            ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 95 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item7

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n        ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "<th>8</th>\r\n            ");
            __builder.AddMarkupContent(52, "<td>\r\n\r\n\r\n                操作步骤<br>\r\n                Steps\r\n\r\n            </td>\r\n            ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 110 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item8

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n\r\n        ");
            __builder.OpenElement(56, "tr");
            __builder.AddMarkupContent(57, "<th>9</th>\r\n            ");
            __builder.AddMarkupContent(58, "<td>\r\n                后置条件<br>\r\n                Post condition\r\n\r\n            </td>\r\n            ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 125 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item9

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n\r\n        ");
            __builder.OpenElement(62, "tr");
            __builder.AddMarkupContent(63, "<th>10</th>\r\n            ");
            __builder.AddMarkupContent(64, "<td>\r\n                备注<br>\r\n                Remark\r\n\r\n\r\n            </td>\r\n            ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 139 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
                 ten.item10

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n<br>\r\n\r\n<img src=\"img/Q120.png\">\r\n<img src=\"img/Q120-2.png\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "D:\Project2021\Project2021\BlazorApp1\Pages\Q120.razor"
       
    private int currentCount = 0;
    MarkupString strTable;



    Ten ten;
    protected override void OnInitialized()
    {

        //  string jsonString = @"{"intItem1":1802,"intItem2":1806,"intItem3":1810,"intItem4":1814,"intItem5":1818,"intItem6":1822,"intItem7":1826,"intItem8":1832,"intItem9":1840,"intItem10":1844,"id":"Q120","item1":"库存属性移转记录数据查询<br> Query the log of post change transfer","item2":"可查询库存属性移转记录<br> Can query the log of post change","item3":"仓管员<br> Warehouse operator","item4":"不适用<br> Not applicable < br > ","item5":"库存信息的查询条件<br> Query conditions for inventory information< br > 输出 < br > ","item6":"转储记录数据 < br > Bin to bin transfer log data < br > 异常处里 < br > ","item7":"如果无符合条件的数据，系统将提示查无此库位信息 < br > If there is no eligible log data, the system will prompt you to find no such location information < br > 如果因为网路中断产生的异常，须结束WES软件，请网路管理人员恢复网路后再重启WES < br > If the WES software needs to be terminated due to an abnormality caused by a network interruption, ask the network administrator to restore the network and restart WES < br > 操作步骤 < br > ","item8":"    1.输入查询条件后点选Query查询库位数据 < br > Enter query conditions and click Query to query the location data < br > 2.点选功能菜单Refresh可清除画面上的数据回到初始状态 < br > Click refresh to clear the data on the screen and return to the initial state < br > 3.点选功能菜单Exit或关闭视窗可结束此作业 < br > Click the function menu exit or close window to end this job<br> 后置条件<br>","item9":"不适用<br> Not applicable<br> 备注<br>","item10":"可以查看回报SAP状态<br> You can view and report SAP status<br>"}";

        string jsonString = System.IO.File.ReadAllText(@"D:\Project2021\Project2021\BlazorApp1\wwwroot\json\Q120.json");


        ten = Newtonsoft.Json.JsonConvert.DeserializeObject<Ten>(jsonString);
        //StringBuilder sb = new StringBuilder();

        ////        sb.Append("< table class=\"gridtable\" width=\"75%\">");
        //sb.Append("<table class=\"gridtable\" width=\"75%\">");
        //sb.Append("<tr><th></th><th width =\"13%\" > Topic 主題</th><th>Description 說明</th></tr>");

        //sb.Append("<tr><th>1</th><td>作业目的<br>Operation purpose</td><td>");
        //sb.Append(ten.item1);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>2</th><td>说明<br>Description</td><td>");
        //sb.Append(ten.item2);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>3</th><td>角色<br>Roles</td><td>");
        //sb.Append(ten.item3);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>4</th><td>前置条件<br>Precondition/td><td>");
        //sb.Append(ten.item4);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>5</th><td>输入<br>Input</td><td>");
        //sb.Append(ten.item5);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>6</th><td>输出<br>Output</td><td>");
        //sb.Append(ten.item6);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>7</th><td>异常处里<br>Abnormal handle</td><td>");
        //sb.Append(ten.item7);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>8</th><td>操作步骤<br>Steps</td><td>");
        //sb.Append(ten.item8);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>9</th><td>后置条件<br>Post condition</td><td>");
        //sb.Append(ten.item9);
        //sb.Append("</td></tr>");

        //sb.Append("<tr><th>10</th><td>备注<br>Remark</td><td>");
        //sb.Append(ten.item10);
        //sb.Append("</td></tr>");

        //sb.Append("</table>");

        //strTable = (MarkupString)sb.ToString();

        strTable = (MarkupString)Util.GetHtmlString(ten);


    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
