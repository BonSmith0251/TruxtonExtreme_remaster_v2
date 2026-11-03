namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
[Token(Token = "0x200010D")]
public interface IContractResolver
{

	[Token(Token = "0x60007C1")]
	public JsonContract ResolveContract(Type type) { }

}

