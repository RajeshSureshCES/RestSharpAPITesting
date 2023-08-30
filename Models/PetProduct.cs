using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RestSharp_API_PetStor.Models
{
	public class PetProduct
	{
		public Int64 Id { get; set; }
		public Category Category { get; set; }
		public string Name { get; set; }

		[XmlAttribute("photoUrls")]
		public IList<string> photoUrls { get; set; }
		public IList<PetTags> Tags { get; set; }
		public string status { get; set; }
	}

	public enum Status
	{
		[EnumMember(Value = "Available")]
		available = 0,

		[EnumMember(Value = "Pending")]
		pending = 1,

		[EnumMember(Value = "Sold")]
		sold = 2
	}

	public class PetTags
	{
		public Int64 Id { get; set; }
		public string Name { get; set; }
	}

	public class Category
	{
		public Int64 Id { get; set; }
		public string Name { get; set; }
	}
}
