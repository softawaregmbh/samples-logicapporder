using System.Web.Http;
using WebActivatorEx;
using LogicAppOrder.CRM;
using Swashbuckle.Application;
using TRex.Metadata;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace LogicAppOrder.CRM
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "LogicAppOrder.CRM");
                        c.ReleaseTheTRex();
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}
