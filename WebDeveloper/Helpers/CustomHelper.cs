using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        private static string GetHtmlForPrice(double price)
        {
            return price == 0.0 ? "<span>Free!!!</span>" : $"<span>{price.ToString()}</span>";
        }

        public static IHtmlString DisplayDateOrNull(this HtmlHelper helper, DateTime? registrationdate)
        {
            return new HtmlString(GetHtmlForDate(registrationdate));
        }

        private static string GetHtmlForDate(DateTime? registrationdate)
        {
            return registrationdate.HasValue ? $"<span>{registrationdate.Value.ToString("dd-mm-yyyy")}</span>" : "<span>None</span>";
        }

    }
}