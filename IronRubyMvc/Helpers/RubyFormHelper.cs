#region Usings

using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public partial class RubyHtmlHelper
    {
        public MvcForm BeginForm()
        {
            return FormExtensions.BeginForm(_helper );
        }

        public MvcForm BeginForm(Hash routeValues)
        {
            return FormExtensions.BeginForm(_helper, routeValues.ToRouteDictionary());
        }


        public MvcForm BeginForm(string actionName, string controllerName)
        {
            return FormExtensions.BeginForm(_helper, actionName, controllerName);
        }

        public MvcForm BeginForm(string actionName, string controllerName, Hash routeValues)
        {
            return FormExtensions.BeginForm(_helper, actionName, controllerName, routeValues.ToRouteDictionary());
        }

        public MvcForm BeginForm(string actionName, string controllerName, FormMethod method)
        {
            return FormExtensions.BeginForm(_helper, actionName, controllerName, method);
        }

        public MvcForm BeginForm(string actionName, string controllerName, Hash routeValues, FormMethod method)
        {
            return FormExtensions.BeginForm(_helper, actionName, controllerName, routeValues.ToRouteDictionary(), method);
        }

        public MvcForm BeginForm(string actionName, string controllerName, FormMethod method, Hash htmlAttributes)
        {
            return FormExtensions.BeginForm(_helper, actionName, controllerName, method, htmlAttributes.ToDictionary());
        }

        public MvcForm BeginForm(string actionName, string controllerName, Hash routeValues, FormMethod method, Hash htmlAttributes)
        {
            return FormExtensions.BeginForm(_helper, actionName, controllerName, routeValues.ToRouteDictionary(), method, htmlAttributes.ToDictionary());
        }

        public MvcForm BeginRouteForm(Hash routeValues)
        {
            return FormExtensions.BeginRouteForm(_helper, routeValues.ToRouteDictionary());
        }

        public MvcForm BeginRouteForm(string routeName)
        {
            return FormExtensions.BeginRouteForm(_helper, routeName);
        }

        public MvcForm BeginRouteForm(string routeName, Hash routeValues)
        {
            return FormExtensions.BeginRouteForm(_helper, routeName, routeValues.ToRouteDictionary());
        }

        public MvcForm BeginRouteForm(string routeName, FormMethod method)
        {
            return FormExtensions.BeginRouteForm(_helper, routeName, method);
        }

        public MvcForm BeginRouteForm(string routeName, Hash routeValues, FormMethod method)
        {
            return FormExtensions.BeginRouteForm(_helper, routeName, routeValues.ToRouteDictionary(), method);
        }

        public MvcForm BeginRouteForm(string routeName, FormMethod method, Hash htmlAttributes)
        {
            return FormExtensions.BeginRouteForm(_helper, routeName, method, htmlAttributes.ToDictionary());
        }

        public MvcForm BeginRouteForm(string routeName, Hash routeValues, FormMethod method, Hash htmlAttributes)
        {
            return FormExtensions.BeginRouteForm(_helper, routeName, routeValues.ToRouteDictionary(), method, htmlAttributes.ToDictionary());
        }

        public void EndForm()
        {
			FormExtensions.EndForm(_helper);
        }
    }
}