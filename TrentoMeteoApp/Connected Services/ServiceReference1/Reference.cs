﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Questo codice è stato generato da uno strumento.
//
//     Le modifiche apportate a questo file possono causare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Giorni", Namespace="http://tempuri.org/")]
    public partial class Giorni : object
    {
        
        private int idPrevisioneGiornoField;
        
        private string giornoField;
        
        private int idIconaField;
        
        private string iconaField;
        
        private string descIconaField;
        
        private string testoGiornoField;
        
        private int tMinGiornoField;
        
        private int tMaxGiornoField;
        
        private ServiceReference1.Fasce[] fasceField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int idPrevisioneGiorno
        {
            get
            {
                return this.idPrevisioneGiornoField;
            }
            set
            {
                this.idPrevisioneGiornoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string giorno
        {
            get
            {
                return this.giornoField;
            }
            set
            {
                this.giornoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int idIcona
        {
            get
            {
                return this.idIconaField;
            }
            set
            {
                this.idIconaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string icona
        {
            get
            {
                return this.iconaField;
            }
            set
            {
                this.iconaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string descIcona
        {
            get
            {
                return this.descIconaField;
            }
            set
            {
                this.descIconaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string testoGiorno
        {
            get
            {
                return this.testoGiornoField;
            }
            set
            {
                this.testoGiornoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int tMinGiorno
        {
            get
            {
                return this.tMinGiornoField;
            }
            set
            {
                this.tMinGiornoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public int tMaxGiorno
        {
            get
            {
                return this.tMaxGiornoField;
            }
            set
            {
                this.tMaxGiornoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public ServiceReference1.Fasce[] fasce
        {
            get
            {
                return this.fasceField;
            }
            set
            {
                this.fasceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fasce", Namespace="http://tempuri.org/")]
    public partial class Fasce : object
    {
        
        private int idPrevisioneFasciaField;
        
        private string fasciaField;
        
        private string fasciaPerField;
        
        private string fasciaOreField;
        
        private string iconaField;
        
        private string descIconaField;
        
        private string idPrecProbField;
        
        private string descPrecProbField;
        
        private string idPrecIntenField;
        
        private string descPrecIntenField;
        
        private string idTempProbField;
        
        private string descTempProbField;
        
        private string idVentoIntQuotaField;
        
        private string descVentoIntQuotaField;
        
        private string idVentoDirQuotaField;
        
        private string descVentoDirQuotaField;
        
        private string idVentoIntValleField;
        
        private string descVentoIntValleField;
        
        private string idVentoDirValleField;
        
        private string descVentoDirValleField;
        
        private string iconaVentoQuotaField;
        
        private int zeroTermicoField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int idPrevisioneFascia
        {
            get
            {
                return this.idPrevisioneFasciaField;
            }
            set
            {
                this.idPrevisioneFasciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fascia
        {
            get
            {
                return this.fasciaField;
            }
            set
            {
                this.fasciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string fasciaPer
        {
            get
            {
                return this.fasciaPerField;
            }
            set
            {
                this.fasciaPerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string fasciaOre
        {
            get
            {
                return this.fasciaOreField;
            }
            set
            {
                this.fasciaOreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string icona
        {
            get
            {
                return this.iconaField;
            }
            set
            {
                this.iconaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string descIcona
        {
            get
            {
                return this.descIconaField;
            }
            set
            {
                this.descIconaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string idPrecProb
        {
            get
            {
                return this.idPrecProbField;
            }
            set
            {
                this.idPrecProbField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string descPrecProb
        {
            get
            {
                return this.descPrecProbField;
            }
            set
            {
                this.descPrecProbField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string idPrecInten
        {
            get
            {
                return this.idPrecIntenField;
            }
            set
            {
                this.idPrecIntenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string descPrecInten
        {
            get
            {
                return this.descPrecIntenField;
            }
            set
            {
                this.descPrecIntenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string idTempProb
        {
            get
            {
                return this.idTempProbField;
            }
            set
            {
                this.idTempProbField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string descTempProb
        {
            get
            {
                return this.descTempProbField;
            }
            set
            {
                this.descTempProbField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string idVentoIntQuota
        {
            get
            {
                return this.idVentoIntQuotaField;
            }
            set
            {
                this.idVentoIntQuotaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string descVentoIntQuota
        {
            get
            {
                return this.descVentoIntQuotaField;
            }
            set
            {
                this.descVentoIntQuotaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string idVentoDirQuota
        {
            get
            {
                return this.idVentoDirQuotaField;
            }
            set
            {
                this.idVentoDirQuotaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string descVentoDirQuota
        {
            get
            {
                return this.descVentoDirQuotaField;
            }
            set
            {
                this.descVentoDirQuotaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public string idVentoIntValle
        {
            get
            {
                return this.idVentoIntValleField;
            }
            set
            {
                this.idVentoIntValleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string descVentoIntValle
        {
            get
            {
                return this.descVentoIntValleField;
            }
            set
            {
                this.descVentoIntValleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public string idVentoDirValle
        {
            get
            {
                return this.idVentoDirValleField;
            }
            set
            {
                this.idVentoDirValleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public string descVentoDirValle
        {
            get
            {
                return this.descVentoDirValleField;
            }
            set
            {
                this.descVentoDirValleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
        public string iconaVentoQuota
        {
            get
            {
                return this.iconaVentoQuotaField;
            }
            set
            {
                this.iconaVentoQuotaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=21)]
        public int zeroTermico
        {
            get
            {
                return this.zeroTermicoField;
            }
            set
            {
                this.zeroTermicoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISoapService")]
    public interface ISoapService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/GetWeather", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetWeatherResponse> GetWeatherAsync(ServiceReference1.GetWeatherRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeather", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetWeatherRequestBody Body;
        
        public GetWeatherRequest()
        {
        }
        
        public GetWeatherRequest(ServiceReference1.GetWeatherRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWeatherRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string day;
        
        public GetWeatherRequestBody()
        {
        }
        
        public GetWeatherRequestBody(string day)
        {
            this.day = day;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeatherResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetWeatherResponseBody Body;
        
        public GetWeatherResponse()
        {
        }
        
        public GetWeatherResponse(ServiceReference1.GetWeatherResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWeatherResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public ServiceReference1.Giorni[] GetWeatherResult;
        
        public GetWeatherResponseBody()
        {
        }
        
        public GetWeatherResponseBody(ServiceReference1.Giorni[] GetWeatherResult)
        {
            this.GetWeatherResult = GetWeatherResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface ISoapServiceChannel : ServiceReference1.ISoapService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class SoapServiceClient : System.ServiceModel.ClientBase<ServiceReference1.ISoapService>, ServiceReference1.ISoapService
    {
        
        /// <summary>
        /// Implementare questo metodo parziale per configurare l'endpoint servizio.
        /// </summary>
        /// <param name="serviceEndpoint">Endpoint da configurare</param>
        /// <param name="clientCredentials">Credenziali del client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SoapServiceClient() : 
                base(SoapServiceClient.GetDefaultBinding(), SoapServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISoapService_soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), SoapServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetWeatherResponse> ServiceReference1.ISoapService.GetWeatherAsync(ServiceReference1.GetWeatherRequest request)
        {
            return base.Channel.GetWeatherAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetWeatherResponse> GetWeatherAsync(string day)
        {
            ServiceReference1.GetWeatherRequest inValue = new ServiceReference1.GetWeatherRequest();
            inValue.Body = new ServiceReference1.GetWeatherRequestBody();
            inValue.Body.day = day;
            return ((ServiceReference1.ISoapService)(this)).GetWeatherAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapService_soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapService_soap))
            {
                return new System.ServiceModel.EndpointAddress("http://trentometeosoap:8080/Service.wsdl");
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SoapServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SoapServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISoapService_soap,
        }
    }
}
