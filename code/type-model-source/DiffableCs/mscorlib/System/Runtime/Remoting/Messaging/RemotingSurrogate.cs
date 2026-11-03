namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003C7")]
internal class RemotingSurrogate : ISerializationSurrogate
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001D4F")]
	public RemotingSurrogate() { }

	[Address(RVA = "0x1F12970", Offset = "0x1F11D70", Length = "0x13B")]
	[Token(Token = "0x6001D4D")]
	public override void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	[Address(RVA = "0x1F12AB0", Offset = "0x1F11EB0", Length = "0x3E")]
	[Token(Token = "0x6001D4E")]
	public override object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

}

