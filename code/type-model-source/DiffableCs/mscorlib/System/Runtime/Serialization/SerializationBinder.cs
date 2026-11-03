namespace System.Runtime.Serialization;

[Token(Token = "0x20003DF")]
public abstract class SerializationBinder
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001DAA")]
	protected SerializationBinder() { }

	[Address(RVA = "0x1F13100", Offset = "0x1F12500", Length = "0x30")]
	[Token(Token = "0x6001DA8")]
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	[Token(Token = "0x6001DA9")]
	public abstract Type BindToType(string assemblyName, string typeName) { }

}

