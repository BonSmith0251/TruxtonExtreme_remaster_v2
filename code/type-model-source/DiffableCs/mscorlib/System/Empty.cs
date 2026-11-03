namespace System;

[Token(Token = "0x2000188")]
internal sealed class Empty : ISerializable
{
	[Token(Token = "0x4000599")]
	public static readonly Empty Value; //Field offset: 0x0

	[Address(RVA = "0x20636F0", Offset = "0x2062AF0", Length = "0x67")]
	[Token(Token = "0x6000DE5")]
	private static Empty() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000DE2")]
	private Empty() { }

	[Address(RVA = "0x2063670", Offset = "0x2062A70", Length = "0x7F")]
	[Token(Token = "0x6000DE4")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000DE3")]
	public virtual string ToString() { }

}

