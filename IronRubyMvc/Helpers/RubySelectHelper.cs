#region Usings

using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public partial class RubyHtmlHelper
    {
        public string DropDownList(string name, string optionLabel)
        {
            return SelectExtensions.DropDownList(_helper, name, optionLabel);
        }

        public string DropDownList(string name, RubyArray selectList, string optionLabel)
        {
            return SelectExtensions.DropDownList(_helper, name, selectList.ToSelectListItemList(), optionLabel);
        }

        public string DropDownList(string name, RubyArray selectList, string optionLabel, Hash htmlAttributes)
        {
            return SelectExtensions.DropDownList(_helper, name, selectList.ToSelectListItemList(), optionLabel, htmlAttributes.ToDictionary());
        }

        public string DropDownList(string name)
        {
            return SelectExtensions.DropDownList(_helper, name);
        }

        public string DropDownList(string name, RubyArray selectList)
        {
            return SelectExtensions.DropDownList(_helper, name, selectList.ToSelectListItemList());
        }

        public string DropDownList(string name, RubyArray selectList, Hash htmlAttributes)
        {
            return SelectExtensions.DropDownList(_helper, name, selectList.ToSelectListItemList(), htmlAttributes.ToDictionary());
        }

        public string ListBox(string name)
        {
            return SelectExtensions.ListBox(_helper, name);
        }

        public string ListBox(string name, RubyArray selectList)
        {
            return SelectExtensions.ListBox(_helper, name, selectList.ToSelectListItemList());
        }

        public string ListBox(string name, RubyArray selectList, Hash htmlAttributes)
        {
            return SelectExtensions.ListBox(_helper, name, selectList.ToSelectListItemList(), htmlAttributes.ToDictionary());
        }
    }
}