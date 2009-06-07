#region Usings

using System.Collections.Generic;
using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using System.Web.Routing;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public partial class RubyHtmlHelper
    {
        public string ActionLink(string linkText, Hash values)
        {
            return LinkExtensions.RouteLink(_helper, linkText, values.ToRouteDictionary());
        }

        public string ActionLink(string linkText, string actionName, Hash values)
        {
            return LinkExtensions.ActionLink(_helper, linkText, actionName, values.ToRouteDictionary());
        }

        public string ActionLink(string linkText, string actionName, string controllerName)
        {
            return LinkExtensions.ActionLink(_helper, linkText, actionName, controllerName);
        }

        public string ActionLink(string linkText, string actionName)
        {
            return LinkExtensions.ActionLink(_helper, linkText, actionName);
        }

        public string ActionLink(string linkText, string actionName, Hash routeValues, Hash htmlAttributes)
        {
            return LinkExtensions.ActionLink(_helper, linkText, actionName, routeValues.ToRouteDictionary(), htmlAttributes.ToDictionary());
        }

        public string ActionLink(string linkText, string actionName, string controllerName, Hash routeValues, Hash htmlAttributes)
        {
            return LinkExtensions.ActionLink(_helper, linkText, actionName, controllerName, routeValues.ToRouteDictionary(), htmlAttributes.ToDictionary());
        }


        public string ActionLink(string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, Hash routeValues, Hash htmlAttributes)
        {
            return LinkExtensions.ActionLink(_helper, linkText, actionName, controllerName, protocol, hostName, fragment, routeValues.ToRouteDictionary(), htmlAttributes.ToDictionary());
        }

        public string RouteLink(string linkText, Hash routeValues)
        {
            return LinkExtensions.RouteLink(_helper, linkText, routeValues.ToRouteDictionary());
        }

        public string RouteLink(string linkText, string routeName, Hash routeValues)
        {
            return LinkExtensions.RouteLink(_helper, linkText, routeName, routeValues.ToRouteDictionary());
        }

        public string RouteLink(string linkText, Hash routeValues, Hash htmlAttributes)
        {
            return LinkExtensions.RouteLink(_helper, linkText, routeValues.ToRouteDictionary(), htmlAttributes.ToDictionary());
        }

        public string RouteLink(string linkText, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            return LinkExtensions.RouteLink(_helper, linkText, null /* routeName */, routeValues, htmlAttributes);
        }

        public string RouteLink(string linkText, string routeName, Hash routeValues, Hash htmlAttributes)
        {
            return LinkExtensions.RouteLink(_helper, linkText, routeName, routeValues.ToRouteDictionary(), htmlAttributes.ToDictionary());
        }


        public string RouteLink(string linkText, string routeName, string protocol, string hostName, string fragment, Hash routeValues, Hash htmlAttributes)
        {
            return LinkExtensions.RouteLink(_helper, linkText, routeName, protocol, hostName, fragment, routeValues.ToRouteDictionary(), htmlAttributes.ToDictionary());
        }
    }
}