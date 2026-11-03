namespace System.Runtime.Serialization;

[Token(Token = "0x20003E7")]
internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F41")]
	private ISerializationSurrogate innerSurrogate; //Field offset: 0x10

	[Address(RVA = "0x1F155E0", Offset = "0x1F149E0", Length = "0xEB")]
	[Token(Token = "0x6001DD8")]
	public override void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F156D0", Offset = "0x1F14AD0", Length = "0xFC")]
	[Token(Token = "0x6001DD9")]
	public override object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }

}

