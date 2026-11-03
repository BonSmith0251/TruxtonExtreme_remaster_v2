namespace System;

[Token(Token = "0x2000135")]
public sealed class CultureAwareComparer : StringComparer, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000442")]
	private readonly CompareInfo _compareInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000443")]
	private CompareOptions _options; //Field offset: 0x18

	[Address(RVA = "0x20428F0", Offset = "0x2041CF0", Length = "0x100")]
	[Token(Token = "0x6000A27")]
	internal CultureAwareComparer(CultureInfo culture, CompareOptions options) { }

	[Address(RVA = "0x2042C60", Offset = "0x2042060", Length = "0xD8")]
	[Token(Token = "0x6000A28")]
	internal CultureAwareComparer(CompareInfo compareInfo, CompareOptions options) { }

	[Address(RVA = "0x2042A00", Offset = "0x2041E00", Length = "0x251")]
	[Token(Token = "0x6000A29")]
	private CultureAwareComparer(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2042600", Offset = "0x2041A00", Length = "0x61")]
	[Token(Token = "0x6000A2A")]
	public virtual int Compare(string x, string y) { }

	[Address(RVA = "0x2042670", Offset = "0x2041A70", Length = "0x59")]
	[Token(Token = "0x6000A2B")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0x20426D0", Offset = "0x2041AD0", Length = "0x8D")]
	[Token(Token = "0x6000A2D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x20427A0", Offset = "0x2041BA0", Length = "0x7C")]
	[Token(Token = "0x6000A2C")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x2042760", Offset = "0x2041B60", Length = "0x39")]
	[Token(Token = "0x6000A2E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2042820", Offset = "0x2041C20", Length = "0xC2")]
	[Token(Token = "0x6000A2F")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

