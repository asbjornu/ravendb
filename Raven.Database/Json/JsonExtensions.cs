using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Raven.Database.Json
{
	public static class JsonExtensions
	{
		public static JObject ToJObject(this byte [] self)
		{
			return JObject.Load(new JsonTextReader(new StreamReader(new MemoryStream(self), Encoding.UTF8)));
		}

		public static T JsonDeserialization<T>(this byte [] self)
		{
			return (T) new JsonSerializer().Deserialize(new JsonTextReader(new StreamReader(new MemoryStream(self))), typeof (T));
		}

		public static T JsonDeserialization<T>(this JObject self)
		{
			return (T)new JsonSerializer().Deserialize(new JTokenReader(self), typeof(T));
		}
	}
}