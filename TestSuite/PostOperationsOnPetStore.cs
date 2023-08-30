using RestSharp;
using RestSharp_API_PetStor.Helper;
using RestSharp_API_PetStore.Actions;
using RestSharp_API_PetStore.Helper;
using RestSharp_API_PetStore.TestSuite;
using Xunit;

namespace RestSharp_API_PetStor.TestSuite
{

	public class PostOperationsOnPetStore : TestBase
	{
		public PostOperationsOnPetStore()
			:base(){ }

        [Fact]
        public void PostOperationTest()
        {
			// Precondition
			RestClient client = RestClientOptionsSettings.GetRestClient();
			RestRequest request = Request.GetRestRequestUsingRequestUrl(Constants.GET_PET_BY_STATUS, Constants.API_METHOD_POST);
			Request.AddHeaderParameter(request);
			Request.AddJSonPetProduct(request);

			// Action
			Response.ExecuteAndGetDetailsOfPet(client, request);

			PetIdsCreatedUsingAutomation.Add(Response.GetPetIDCreatedUsingAutomation());

		}
    }
}
