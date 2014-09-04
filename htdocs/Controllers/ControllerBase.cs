using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace WebUmbrella_MVC4
{
    public class ControllerBase : Controller
    {

        public ControllerBase()
        {
            this.ViewEngineCollection.Clear();
            this.ViewEngineCollection.Add(new CustomViewEngine());
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new System.IO.StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

        public class CustomViewEngine : RazorViewEngine
        {
            public CustomViewEngine()
            {
                var viewLocations = new[] 
                {  
                    "~/Views/{0}.cshtml",  
                    "~/Views/{1}/{0}.cshtml"
                };
                SetViewEngine(viewLocations);
            }
            public CustomViewEngine(string[] viewLocations)
            {
                SetViewEngine(viewLocations);
            }
            public static void SetViewEngine(string viewLocation, ViewEngineCollection viewEngineCollection)
            {
                viewEngineCollection.Clear();
                CustomViewEngine cve = new CustomViewEngine();
                cve.SetViewEngine(viewLocation);
                viewEngineCollection.Add(cve);
            }
            public static void SetViewEngine(string[] viewLocation, ViewEngineCollection viewEngineCollection)
            {
                viewEngineCollection.Clear();
                CustomViewEngine cve = new CustomViewEngine();
                cve.SetViewEngine(viewLocation);
                viewEngineCollection.Add(cve);
            }
            public void SetViewEngine(string viewLocation)
            {
                SetViewEngine(new string[] { viewLocation });
            }
            public void SetViewEngine(string[] viewLocations)
            {
                this.PartialViewLocationFormats = viewLocations;
                this.ViewLocationFormats = viewLocations;
            }
        }
        public class HttpParamActionAttribute : ActionNameSelectorAttribute
        {
            public override bool IsValidName(ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo)
            {
                if (actionName.Equals(methodInfo.Name, StringComparison.InvariantCultureIgnoreCase))
                    return true;

                var request = controllerContext.RequestContext.HttpContext.Request;
                return request[methodInfo.Name] != null;
            }
        }
    }
}