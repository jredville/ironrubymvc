#region Usings

using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public partial class RubyHtmlHelper
    {
        public string TextArea(string name)
        {
            return TextAreaExtensions.TextArea(_helper, name);
        }

        public string TextArea(string name, Hash htmlAttributes)
        {
            return TextAreaExtensions.TextArea(_helper, name, htmlAttributes.ToDictionary());
        }

        public string TextArea(string name, string value)
        {
            return TextAreaExtensions.TextArea(_helper, name, value);
        }

        public string TextArea(string name, string value, Hash htmlAttributes)
        {
            return TextAreaExtensions.TextArea(_helper, name, value, htmlAttributes.ToDictionary());
        }

        public string TextArea(string name, string value, int rows, int columns, Hash htmlAttributes)
        {
            return TextAreaExtensions.TextArea(_helper, name, value, rows, columns, htmlAttributes.ToDictionary());
        }
    }
}