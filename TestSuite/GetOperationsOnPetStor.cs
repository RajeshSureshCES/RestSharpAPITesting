using RestSharp;
using RestSharp_API_PetStor.Helper;
using RestSharp_API_PetStore.Actions;
using RestSharp_API_PetStore.Helper;
using RestSharp_API_PetStore.TestSuite;
using Xunit;

namespace RestSharp_API_PetStor.TestSuite
{
	public class GetOperationsOnPetStor : TestBase
	{
		public GetOperationsOnPetStor()
			: base(){ }

		[Fact]
        public void GetAllPetDetailsByStatusAvailable()
        {
			// Precondition
			RestClient client = RestClientOptionsSettings.GetRestClient();
            RestRequest request = Request.GetRestRequestUsingRequestUrl(Constants.GET_PET_BY_STATUS, Constants.API_METHOD_GET);
			Request.AddHeaderParameter(request);
			Request.AddUrlParameters(request, Constants.STATUS, Constants.STATUS_AVAILABLE);

			// Action
			Response.ExecuteAndGetDetailsOfPet(client, request);

			// Validation
			Assert.True(Response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK, "Status Code is not 'OK'");
			Assert.True(Response.PetProducts.Count > 0, "Unable to fecth all the Pet details with status Available");
			Assert.True(Response.VerifyStatusOfPet(Constants.STATUS_AVAILABLE), "Unable to fecth all the Pet details with status Available");
		}

		[Fact]
		public void GetAllPetDetailsByStatusPending()
		{
			// Precondition
			RestClient client = RestClientOptionsSettings.GetRestClient();
			RestRequest request = Request.GetRestRequestUsingRequestUrl(Constants.GET_PET_BY_STATUS, Constants.API_METHOD_GET);
			Request.AddHeaderParameter(request);
			Request.AddUrlParameters(request, Constants.STATUS, Constants.STATUS_PENDING);

			// Action
			Response.ExecuteAndGetDetailsOfPet(client, request);

			// Validation
			Assert.True(Response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK, "Status Code is not 'OK'");
			Assert.True(Response.PetProducts.Count > 0, "Unable to fecth all the Pet details with status Pending");
			Assert.True(Response.VerifyStatusOfPet(Constants.STATUS_PENDING), "Unable to fecth all the Pet details with status Pending");
			Dispose();
		}

		[Fact]
		public void GetAllPetDetailsByStatusSold()
		{
			// Precondition
			RestClient client = RestClientOptionsSettings.GetRestClient();
			RestRequest request = Request.GetRestRequestUsingRequestUrl(Constants.GET_PET_BY_STATUS, Constants.API_METHOD_GET);
			Request.AddHeaderParameter(request);
			Request.AddUrlParameters(request, Constants.STATUS, Constants.STATUS_SOLD);

			// Action
			Response.ExecuteAndGetDetailsOfPet(client, request);

			// Validation
			Assert.True(Response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK, "Status Code is not 'OK'");
			Assert.True(Response.PetProducts.Count > 0, "Unable to fecth all the Pet details with status Sold");
			Assert.True(Response.VerifyStatusOfPet(Constants.STATUS_SOLD), "Unable to fecth all the Pet details with status Available");
			Dispose();
		}

		public void Dispose()
		{
			if (Request != null || Response != null)
			{
				Request = null;
				Response = null;
			}
		}
	}
}