namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003C8")]
internal class ObjRefSurrogate : ISerializationSurrogate
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001D52")]
	public ObjRefSurrogate() { }

	[Address(RVA = "0x1F0C630", Offset = "0x1F0BA30", Length = "0x105")]
	[Token(Token = "0x6001D50")]
	public override void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	[Address(RVA = "0x1F0C740", Offset = "0x1F0BB40", Length = "0x4E")]
	[Token(Token = "0x6001D51")]
	public override object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

}

