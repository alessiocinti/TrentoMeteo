using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using System.ServiceModel;
using TrentoMeteoApp.ViewModels;

namespace TrentoMeteoApp.Controllers
{
    public class MeteoController : Controller
    {
        //Il metodo Index è il principale che riceve un parametro "giorno" dalla richiesta HTTP
        public IActionResult Index(String day)
        {
            //Creo canale per servizio SOAP utilizzando il client dato da "ServiceReference1" ossia il servizio dato
            ISoapService soapServiceChannel = new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);

            //Chiamata al servizio SOAP GetWeather, dando un oggetto GetWeatherRequest, con corpo GetWeatherRequestBody
            //La chiamata è attesa in modo asincrono (".Result)
            var response = soapServiceChannel.GetWeatherAsync(new GetWeatherRequest()
            {
                Body = new GetWeatherRequestBody()
                {
                    day = day
                }
            }).Result;

            //Costruisce oggetto MeteoIndexViewModel che verra usato per passare i dati alla vista
            //Il campo giorni viene riempito da l'array di risultati ottenuti dalla chiamata al servizio SOAP
            MeteoIndexViewModel viewModel = new MeteoIndexViewModel()
            {
                giorni = response.Body.GetWeatherResult.ToArray()
            };

            //Restituisce la vista
            return View(viewModel);
        }
    }
}
