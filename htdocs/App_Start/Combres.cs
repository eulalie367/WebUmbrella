[assembly: WebActivator.PreApplicationStartMethod(typeof(WebUmbrella_MVC2.App_Start.Combres), "PreStart")]
namespace WebUmbrella_MVC2.App_Start {
	using System.Web.Routing;
	using global::Combres;
	
    public static class Combres {
        public static void PreStart() {
            RouteTable.Routes.AddCombresRoute("Combres");
        }
    }
}