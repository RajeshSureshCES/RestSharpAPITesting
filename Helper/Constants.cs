using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_API_PetStore.Helper
{
	public static class Constants
	{
		//Base URL
		public const string BASE_URL = "https://petstore.swagger.io/v2/";

		// API METHODs
		public const string API_METHOD_GET = "Get";
		public const string API_METHOD_PUT = "Put";
		public const string API_METHOD_DELETE = "Delete";
		public const string API_METHOD_POST = "Post";

		// RequestURL
		public const string GET_PET_BY_STATUS = "pet/findByStatus";
		public const string GET_PET_BY_ID = "pet/";

		// segment Name
		public const string STATUS = "status";

		// Parameters
		public const string STATUS_AVAILABLE = "available";
		public const string STATUS_SOLD = "sold";
		public const string STATUS_PENDING = "pending";

		// Content Type
		public const string CONTENT_JSON = "JSON";
		public const string CONTENT_NAME_JSON = "accept";
		public const string CONTENT_JSON_RSHARP = "application/json";

	}
}
