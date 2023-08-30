using System;
using RestSharp;
using RestSharp_API_PetStore.Helper;

namespace RestSharp_API_PetStore.Actions
{

    public interface IRestLibrary
    {
        RestClient RestClient { get; }
    }

    public class RestLibrary : IRestLibrary
    {
        public RestLibrary()
        {
            var restClientOptions = new RestClientOptions
            {
                BaseUrl = new Uri(Constants.BASE_URL),
                RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
            };

            //Rest Client
            RestClient = new RestClient(restClientOptions);
        }

        public RestClient RestClient { get; }
    }
}
