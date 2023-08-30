using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp_API_PetStor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_API_PetStore.Actions
{
	public class Response
	{
		public RestResponse RestResponse;
		public IList<PetProduct> PetProducts;


		public void ExecuteAndGetDetailsOfPet(RestClient client, RestRequest request)
		{
			RestResponse = client.Execute(request);
			PetProducts = JsonConvert.DeserializeObject<IList<PetProduct>>(RestResponse.Content);
		}

		public bool VerifyStatusOfPet(string statusToFilter)
		{
			return PetProducts.All(x => x.status.Equals(statusToFilter));
		}

		public Int64 GetPetIDCreatedUsingAutomation() => PetProducts[0].Id;

		public  Int64 ExecuteAndGetIDValue(RestClient client, RestRequest restSharpRequest)
		{
			RestResponse = client.Execute(restSharpRequest);
			var details = JObject.Parse(RestResponse.Content);
			return (Int64)details["id"];
		}
	}
}
