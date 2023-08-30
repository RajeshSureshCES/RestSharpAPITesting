using RestSharp;
using RestSharp_API_PetStor.Helper;
using RestSharp_API_PetStore.Actions;
using RestSharp_API_PetStore.Helper;

namespace RestSharp_API_PetStore.TestSuite
{
	public class TestBase
	{
		public Request Request { get; set; }
		public Response Response { get; set; }

		public List<Int64> PetIdsCreatedUsingAutomation { get; }


		public TestBase()
		{
			Request = new Request();
			Response = new Response();
			
			// Creating the New Pet for fetching by ID and other useful operation.
			Request request = new Request();
			RestClient client = RestClientOptionsSettings.GetRestClient();
			RestRequest restSharpRequest = request.GetRestRequestUsingRequestUrl(Constants.GET_PET_BY_ID, Constants.API_METHOD_POST);
			Dictionary<string, string> headers = new Dictionary<string, string>();
			headers.Add("accept", "application/json");
			headers.Add("Content-Type", "application/json");
			request.AddHeaderParameter(restSharpRequest, headers);
			request.AddJSonPetProduct(restSharpRequest);

			Response response = new Response();
			Int64 idValue = response.ExecuteAndGetIDValue(client, restSharpRequest);

			PetIdsCreatedUsingAutomation.Add(idValue);
		}
	}
}
