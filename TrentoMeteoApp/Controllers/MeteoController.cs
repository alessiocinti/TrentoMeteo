using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using System.ServiceModel;
using TrentoMeteoApp.ViewModels;

namespace TrentoMeteoApp.Controllers
{
    public class MeteoController : Controller
    {
        public IActionResult Index(String day)
        {


            



            ISoapService soapServiceChannel = new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);

            var response = soapServiceChannel.GetWeatherAsync(new GetWeatherRequest()
            {
                Body = new GetWeatherRequestBody()
                {
                    day = day
                }
            }).Result;
            

            
            MeteoIndexViewModel viewModel = new MeteoIndexViewModel()
            {
                listaGiorni = response.Body.GetWeatherResult.ToArray()
            };

            return View(viewModel);
        }
    }
}
