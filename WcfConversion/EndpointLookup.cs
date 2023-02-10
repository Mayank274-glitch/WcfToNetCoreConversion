using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WcfConversion
{
    public class EndpointLookup : DynamicRouteValueTransformer
    {
        public EndpointLookup()
        {
        }

        public override async ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            values = new RouteValueDictionary();
            //CancellationToken token = default;
            //var body = await XElement.LoadAsync(Microsoft.AspNetCore.Mvc.ControllerContext.HttpContext.Request.Body, LoadOptions.None) ;
            values.Add("Action", "GetData");
            values.Add("Controller", "WcfServiceTest");
            await Task.Delay(0);
            return values;
        }
    }
}
