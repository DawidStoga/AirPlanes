using AirPlane.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.HtmlHelpers
{
    //Extension for HTMLHelper
    public static class PagingHelpers
    {

   public static MvcHtmlString PageLinks (this HtmlHelper html,PagingInfo pagingInfo, Func<int, string> pageUrl)
        {

            StringBuilder result = new StringBuilder();
            for( int pag = 1; pag<=pagingInfo.TotalPages; pag++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(pag));
                tag.InnerHtml = "["+ pag.ToString()+"]";
                if(pag == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
           

        }
     
    }
}