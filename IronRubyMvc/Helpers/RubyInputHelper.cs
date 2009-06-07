#region Usings

using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public partial class RubyHtmlHelper
    {
        public string CheckBox(string name)
        {
            return InputExtensions.CheckBox(_helper, name, (object) null /* htmlAttributes */);
        }

        public string CheckBox(string name, bool isChecked)
        {
            return InputExtensions.CheckBox(_helper, name, isChecked, (object) null /* htmlAttributes */);
        }

        public string CheckBox(string name, bool isChecked, Hash htmlAttributes)
        {
            return InputExtensions.CheckBox(_helper, name, isChecked, htmlAttributes.ToDictionary());
        }

        public string CheckBox(string name, Hash htmlAttributes)
        {
            return InputExtensions.CheckBox(_helper, name, htmlAttributes.ToDictionary());
        }

        public string Hidden(string name)
        {
            return InputExtensions.Hidden(_helper, name, null /* value */);
        }

        public string Hidden(string name, object value)
        {
            return InputExtensions.Hidden(_helper, name, value, (object) null /* hmtlAttributes */);
        }

        public string Hidden(string name, object value, Hash htmlAttributes)
        {
            return InputExtensions.Hidden(_helper, name, value, htmlAttributes.ToDictionary());
        }

        public string Password(string name)
        {
            return InputExtensions.Password(_helper, name, null /* value */);
        }

        public string Password(string name, object value)
        {
            return InputExtensions.Password(_helper, name, value, (object) null /* htmlAttributes */);
        }

        public string Password(string name, object value, Hash htmlAttributes)
        {
            return InputExtensions.Password(_helper, name, value, htmlAttributes.ToDictionary());
        }

        public string RadioButton(string name, object value)
        {
            return InputExtensions.RadioButton(_helper, name, value, (object) null /* htmlAttributes */);
        }

        public string RadioButton(string name, object value, Hash htmlAttributes)
        {
            return InputExtensions.RadioButton(_helper, name, value, htmlAttributes.ToDictionary());
        }

        public string RadioButton(string name, object value, bool isChecked)
        {
            return InputExtensions.RadioButton(_helper, name, value, isChecked, (object) null /* htmlAttributes */);
        }

        public string RadioButton(string name, object value, bool isChecked, Hash htmlAttributes)
        {
            return InputExtensions.RadioButton(_helper, name, value, isChecked, htmlAttributes.ToDictionary());
        }


        public string TextBox(string name, object value, Hash htmlAttributes)
        {
            return InputExtensions.TextBox(_helper, name, value, htmlAttributes.ToDictionary());
        }

        public string TextBox(string name)
        {
            //Yeah, I know this is sooo wrong, but still.
            name = name.Replace("_", "");
            return InputExtensions.TextBox(_helper, name);
        }

        public string TextBox(string name, object value)
        {
            //Yeah, I know this is sooo wrong, but still.
            name = name.Replace("_", "");
            if (value == null)
                value = string.Empty;

            return InputExtensions.TextBox(_helper, name, value.ToString());
        }
    }
}