using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Util
    {

        public static string GetHtmlStringExtAll(string wwwroot,string id)
        {
            var file = wwwroot + "/json/" + id + ".json";
            string result = "";
            if (File.Exists(file))
            {
                try
                {
                    string jsonString = System.IO.File.ReadAllText(file);
                    var ten = Newtonsoft.Json.JsonConvert.DeserializeObject<Ten>(jsonString);
                    var temp = GetHtmlString(ten);
                    result = "<br />" + temp + "<br />";

                }
                catch(Exception ex)
                {
                    //
                    var msg = ex.Message;
                }
            }
            var img1 = wwwroot + "/img/" + id + ".png";
            var img2 = wwwroot + "/img/" + id + "-2.png";
            var img3 = wwwroot + "/img/" + id + "-3.png";


            if (File.Exists(img1))
            {
                result += String.Format("<img src=\"img/{0}\" />", id + ".png");
            }
            if (File.Exists(img2))
            {
                result += String.Format("<img src=\"img/{0}\" />", id + "-2.png");
            }
            if (File.Exists(img3))
            {
                result += String.Format("<img src=\"img/{0}\" />", id + "-3.png");
            }


            return result;

           
        }



        public static string GetHtmlStringExt(string id)
        {
            string jsonString = System.IO.File.ReadAllText(@"D:\Project2021\Project2021\BlazorApp1\wwwroot\json\"+id+".json");


            var ten = Newtonsoft.Json.JsonConvert.DeserializeObject<Ten>(jsonString);

            return GetHtmlString(ten);
        }


        public static string GetHtmlString(Ten ten)
        {
            StringBuilder sb = new StringBuilder();

            //        sb.Append("< table class=\"gridtable\" width=\"75%\">");
            sb.Append("<table class=\"gridtable\" width=\"85%\">");
            sb.Append("<tr><th></th><th width =\"13%\" > Topic 主題</th><th>Description 說明</th></tr>");

            sb.Append("<tr><th>1</th><td>作业目的<br>Operation purpose</td><td>");
            sb.Append(ten.item1);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>2</th><td>说明<br>Description</td><td>");
            sb.Append(ten.item2);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>3</th><td>角色<br>Roles</td><td>");
            sb.Append(ten.item3);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>4</th><td>前置条件<br>Precondition/td><td>");
            sb.Append(ten.item4);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>5</th><td>输入<br>Input</td><td>");
            sb.Append(ten.item5);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>6</th><td>输出<br>Output</td><td>");
            sb.Append(ten.item6);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>7</th><td>异常处里<br>Abnormal handle</td><td>");
            sb.Append(ten.item7);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>8</th><td>操作步骤<br>Steps</td><td>");
            sb.Append(ten.item8);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>9</th><td>后置条件<br>Post condition</td><td>");
            sb.Append(ten.item9);
            sb.Append("</td></tr>");

            sb.Append("<tr><th>10</th><td>备注<br>Remark</td><td>");
            sb.Append(ten.item10);
            sb.Append("</td></tr>");

            sb.Append("</table>");
            return sb.ToString();
        }
    }
}
