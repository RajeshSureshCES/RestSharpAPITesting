using RestSharp;
using RestSharp_API_PetStore.Helper;

namespace RestSharp_API_PetStor.Helper
{
	public class RestClientOptionsSettings
	{
		public static RestClient GetRestClient()
		{
			var restClientOptions = new RestClientOptions
			{
				BaseUrl = new Uri(Constants.BASE_URL),
				RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
			};

			// RestSharp Client
			return new RestClient(restClientOptions);
		}
	}
}
