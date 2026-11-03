namespace System.Runtime.Serialization;

[Token(Token = "0x20003DA")]
public sealed class SerializationEventHandler : MulticastDelegate
{

	[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
	[Token(Token = "0x6001D98")]
	public SerializationEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
	[Token(Token = "0x6001D99")]
	public override void Invoke(StreamingContext context) { }

}

