namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
[Token(Token = "0x200010F")]
public interface ISerializationBinder
{

	[NullableContext(2)]
	[Token(Token = "0x60007C7")]
	public void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	[Token(Token = "0x60007C6")]
	public Type BindToType(string assemblyName, string typeName) { }

}

