#region Usings

using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers {
    public partial class RubyHtmlHelper {
        public MvcHtmlString CheckBox(string name) {
            return _helper.CheckBox(name, (object)null /* htmlAttributes */);
        }

        public MvcHtmlString CheckBox(string name, bool isChecked) {
            return _helper.CheckBox(name, isChecked, (object)null /* htmlAttributes */);
        }

        public MvcHtmlString CheckBox(string name, bool isChecked, Hash htmlAttributes) {
            return _helper.CheckBox(name, isChecked, htmlAttributes.ToDictionary());
        }

        public MvcHtmlString CheckBox(string name, Hash htmlAttributes) {
            return _helper.CheckBox(name, htmlAttributes.ToDictionary());
        }

        public MvcHtmlString Hidden(string name) {
            return _helper.Hidden(name, null /* value */);
        }

        public MvcHtmlString Hidden(string name, object value) {
            return _helper.Hidden(name, value, (object)null /* hmtlAttributes */);
        }

        public MvcHtmlString Hidden(string name, object value, Hash htmlAttributes) {
            return _helper.Hidden(name, value, htmlAttributes.ToDictionary());
        }

        public MvcHtmlString Password(string name) {
            return _helper.Password(name, null /* value */);
        }

        public MvcHtmlString Password(string name, object value) {
            return _helper.Password(name, value, (object)null /* htmlAttributes */);
        }

        public MvcHtmlString Password(string name, object value, Hash htmlAttributes) {
            return _helper.Password(name, value, htmlAttributes.ToDictionary());
        }

        public MvcHtmlString RadioButton(string name, object value) {
            return _helper.RadioButton(name, value, (object)null /* htmlAttributes */);
        }

        public MvcHtmlString RadioButton(string name, object value, Hash htmlAttributes) {
            return _helper.RadioButton(name, value, htmlAttributes.ToDictionary());
        }

        public MvcHtmlString RadioButton(string name, object value, bool isChecked) {
            return _helper.RadioButton(name, value, isChecked, (object)null /* htmlAttributes */);
        }

        public MvcHtmlString RadioButton(string name, object value, bool isChecked, Hash htmlAttributes) {
            return _helper.RadioButton(name, value, isChecked, htmlAttributes.ToDictionary());
        }


        public MvcHtmlString TextBox(string name, object value, Hash htmlAttributes) {
            return _helper.TextBox(name, value, htmlAttributes.ToDictionary());
        }

        public MvcHtmlString TextBox(string name) {
            //TODO: Yeah, I know this is sooo wrong, but still.
            name = name.Replace("_", "");
            return _helper.TextBox(name);
        }

        public MvcHtmlString TextBox(string name, object value) {
            //TODO: Yeah, I know this is sooo wrong, but still.
            name = name.Replace("_", "");
            if (value == null)
                value = string.Empty;

            return _helper.TextBox(name, value.ToString());
        }
    }
}