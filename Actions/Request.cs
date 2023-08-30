using NUnit.Framework.Internal;
using RestSharp;
using RestSharp_API_PetStor.Models;
using RestSharp_API_PetStore.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_API_PetStore.Actions
{
	public class Request
	{
		public RestRequest GetRestRequestUsingRequestUrl(string requestUrl, string apiMethod)
		{
			Method method = (Method)Enum.Parse(typeof(Method), apiMethod);
			return new RestRequest(requestUrl, method);
		}

		public void AddHeaderParameter(RestRequest restRequest, Dictionary<string, string> headerParameters = null)
		{
			if (headerParameters == null)
			{
				headerParameters = new Dictionary<string, string>();
				headerParameters.Add("accept", "application/json");
			}

			foreach (KeyValuePair<string, string> headerKeyPair in headerParameters)
				restRequest.AddHeader(headerKeyPair.Key, headerKeyPair.Value);
		}

		public void AddUrlParameters(RestRequest restRequest, string name, string value)
		{
			restRequest.AddQueryParameter(name, value);
		}

		public void AddJSonPetProduct(RestRequest restRequest)
		{
			restRequest.AddJsonBody(new PetProduct
			{
				Name = "Automation_Created",
				status = Constants.STATUS_AVAILABLE
			});
		}
	}
}
