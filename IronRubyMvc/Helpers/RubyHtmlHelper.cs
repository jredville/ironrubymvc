#region Usings

using System.Web.Mvc.Html;
using System.Web.Mvc.IronRuby.Extensions;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Helpers
{
    public partial class RubyHtmlHelper : HtmlHelper
    {
        private readonly HtmlHelper _helper;

        public RubyHtmlHelper(ViewContext context, IViewDataContainer viewDataContainer)
            : base(context, viewDataContainer)
        {
            _helper = new HtmlHelper(context, viewDataContainer);
        }


        public void RenderPartial(string partialViewName)
        {
            RenderPartialExtensions.RenderPartial(_helper, partialViewName);
        }

        public void RenderPartial(string partialViewName, object model)
        {
            RenderPartialExtensions.RenderPartial(_helper, partialViewName, model);
        }

        public void RenderPartial(string partialViewName, Hash viewData)
        {
            RenderPartialExtensions.RenderPartial(_helper, partialViewName, viewData.ToViewDataDictionary());
        }

        public void RenderPartial(string partialViewName, object model, Hash viewData)
        {
            RenderPartialExtensions.RenderPartial(_helper, partialViewName, model, viewData.ToViewDataDictionary());
        }
    }
}