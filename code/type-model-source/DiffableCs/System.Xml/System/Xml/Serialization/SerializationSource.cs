namespace System.Xml.Serialization;

[Token(Token = "0x20000FE")]
internal abstract class SerializationSource
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005ED")]
	private Type[] includedTypes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005EE")]
	private string namspace; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005EF")]
	private bool canBeGenerated; //Field offset: 0x20

	[Address(RVA = "0x2543760", Offset = "0x2542B60", Length = "0x52")]
	[Token(Token = "0x6000C05")]
	public SerializationSource(string namspace, Type[] includedTypes) { }

	[Address(RVA = "0x2543650", Offset = "0x2542A50", Length = "0x106")]
	[Token(Token = "0x6000C06")]
	protected bool BaseEquals(SerializationSource other) { }

}

