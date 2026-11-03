namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[NullableContext(1)]
[Token(Token = "0x2000160")]
public interface IJEnumerable : IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x170001CF")]
	public IJEnumerable<JToken> Item
	{
		[Token(Token = "0x6000B19")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000B19")]
	public IJEnumerable<JToken> get_Item(object key) { }

}

