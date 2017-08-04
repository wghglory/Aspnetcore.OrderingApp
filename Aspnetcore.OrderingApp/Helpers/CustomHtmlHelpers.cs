using System;
using System.IO;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Aspnetcore.OrderingApp.Helpers
{
    public static class CustomHtmlHelpers
    {
        // 上面是label占一行，下面一行是input
        public static IHtmlContent LabeledTextboxFor<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression, string labelText)
        {
            var label = htmlHelper.LabelFor(expression, labelText);
            var textBox =  htmlHelper.TextBoxFor(expression, new { @class = "form-control" });

            var writer = new StringWriter();
            label.WriteTo(writer, HtmlEncoder.Default);
            textBox.WriteTo(writer, HtmlEncoder.Default);

            return new HtmlString(writer.GetStringBuilder().ToString());
        }
    }
}
