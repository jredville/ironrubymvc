#region Usings

using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using System.Web.Routing;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public class RubyAjaxHelper : AjaxHelper
    {
        private readonly AjaxHelper _helper;

        public RubyAjaxHelper(ViewContext viewContext, IViewDataContainer viewDataContainer) : base(viewContext, viewDataContainer)
        {
            _helper = new AjaxHelper(viewContext, viewDataContainer);
        }

        public RubyAjaxHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection) : base(viewContext, viewDataContainer, routeCollection)
        {
            _helper = new AjaxHelper(viewContext, viewDataContainer, routeCollection);
        }

        public string ActionLink(string linkText, string actionName, AjaxOptions ajaxOptions)
        {
			return AjaxExtensions.ActionLink(_helper, linkText, actionName, ajaxOptions);
        }

        public string ActionLink(string linkText, string actionName, Hash routeValues, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.ActionLink(_helper, linkText, actionName, routeValues.ToRouteDictionary(), ajaxOptions);
        }

        public string ActionLink(string linkText, string actionName, Hash routeValues, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.ActionLink(_helper, linkText, actionName, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }

        public string ActionLink(string linkText, string actionName, string controllerName, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.ActionLink(_helper, linkText, actionName, controllerName, null /* values */, ajaxOptions, null /* htmlAttributes */);
        }

        public string ActionLink(string linkText, string actionName, string controllerName, Hash routeValues, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.ActionLink(_helper, linkText, actionName, controllerName, routeValues, ajaxOptions, null /* htmlAttributes */);
        }

        public string ActionLink(string linkText, string actionName, string controllerName, Hash routeValues, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.ActionLink(_helper, linkText, actionName, controllerName, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }

        public string ActionLink(string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, Hash routeValues, AjaxOptions ajaxOptions,
                                 Hash htmlAttributes)
        {
            return AjaxExtensions.ActionLink(_helper, linkText, actionName, controllerName, protocol, hostName, fragment, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }


        public MvcForm BeginForm(AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.BeginForm(_helper, ajaxOptions);
        }

        public MvcForm BeginForm(string actionName, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.BeginForm(_helper, actionName, ajaxOptions);
        }

        public MvcForm BeginForm(string actionName, Hash routeValues, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.BeginForm(_helper, actionName, routeValues.ToRouteDictionary(), ajaxOptions);
        }

        public MvcForm BeginForm(string actionName, Hash routeValues, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.BeginForm(_helper, actionName, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }

        public MvcForm BeginForm(string actionName, string controllerName, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.BeginForm(_helper, actionName, controllerName, ajaxOptions);
        }

        public MvcForm BeginForm(string actionName, string controllerName, Hash routeValues, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.BeginForm(_helper, actionName, controllerName, routeValues.ToRouteDictionary(), ajaxOptions);
        }

        public MvcForm BeginForm(string actionName, string controllerName, Hash routeValues, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.BeginForm(_helper, actionName, controllerName, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }

        public MvcForm BeginRouteForm(string routeName, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.BeginRouteForm(_helper, routeName, ajaxOptions);
        }

        public MvcForm BeginRouteForm(string routeName, Hash routeValues, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.BeginRouteForm(_helper, routeName, routeValues.ToRouteDictionary(), ajaxOptions);
        }

        public MvcForm BeginRouteForm(string routeName, Hash routeValues, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.BeginRouteForm(_helper, routeName, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }

        public string RouteLink(string linkText, Hash routeValues, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.RouteLink(_helper, linkText, routeValues.ToRouteDictionary(), ajaxOptions);
        }

        public string RouteLink(string linkText, Hash routeValues, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.RouteLink(_helper, linkText, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }

        public string RouteLink(string linkText, string routeName, AjaxOptions ajaxOptions)
        {
			return AjaxExtensions.RouteLink(_helper, linkText, routeName, ajaxOptions);
        }

        public string RouteLink(string linkText, string routeName, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.RouteLink(_helper, linkText, routeName, ajaxOptions, htmlAttributes.ToDictionary());
        }

        public string RouteLink(string linkText, string routeName, Hash routeValues, AjaxOptions ajaxOptions)
        {
            return AjaxExtensions.RouteLink(_helper, linkText, routeName, routeValues.ToRouteDictionary(), ajaxOptions);
        }

        public string RouteLink(string linkText, string routeName, Hash routeValues, AjaxOptions ajaxOptions, Hash htmlAttributes)
        {
            return AjaxExtensions.RouteLink(_helper, linkText, routeName, routeValues.ToRouteDictionary(), ajaxOptions, htmlAttributes.ToDictionary());
        }
    }
}