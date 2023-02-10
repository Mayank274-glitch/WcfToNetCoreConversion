using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WcfConversion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WcfServiceTestController : Controller
    {

        [Route("GetData")]
        public async Task<IActionResult> GetData(int value)
        
        {
            CancellationToken token = new CancellationToken();
            var body = await ReadFromPostBodyAsync(token);
             XNamespace tempUri = "http://tempuri.org/";
            var response = new XElement(tempUri + "GetDataResponse",
        new XElement(tempUri + "GetDataResult",
          "This is a test"
        ));
            await Task.Delay(0);
            var result = Content(WrapInSoapResponse(response).ToString(), new Microsoft.Net.Http.Headers.MediaTypeHeaderValue("text/xml"));
           
            return result;
        }


        private XElement WrapInSoapResponse(XElement content)
        {
           XNamespace soap = "http://schemas.xmlsoap.org/soap/envelope/";
            return new XElement(soap + "Envelope", new XElement(soap + "Body", content));
        }

        private async Task<XElement> ReadFromPostBodyAsync(CancellationToken token)
        {
            return await XElement.LoadAsync(ControllerContext.HttpContext.Request.Body, LoadOptions.None, token);
        }
    }
}
