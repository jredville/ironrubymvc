#region Usings

using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public partial class RubyHtmlHelper
    {
        public string ValidationMessage(string modelName)
        {
            return ValidationExtensions.ValidationMessage(_helper, modelName);
        }

        public string ValidationMessage(string modelName, Hash htmlAttributes)
        {
            return ValidationExtensions.ValidationMessage(_helper, modelName, htmlAttributes.ToDictionary());
        }

        public string ValidationMessage(string modelName, string validationMessage)
        {
            return ValidationExtensions.ValidationMessage(_helper, modelName, validationMessage);
        }

        public string ValidationMessage(string modelName, string validationMessage, Hash htmlAttributes)
        {
            return ValidationExtensions.ValidationMessage(_helper, modelName, validationMessage, htmlAttributes.ToDictionary());
        }

        public string ValidationSummary()
        {
            return ValidationExtensions.ValidationSummary(_helper );
        }

        public string ValidationSummary(string message)
        {
            return ValidationExtensions.ValidationSummary(_helper, message);
        }

        public string ValidationSummary(string message, Hash htmlAttributes)
        {
            return ValidationExtensions.ValidationSummary(_helper, message, htmlAttributes.ToDictionary());
        }
    }
}