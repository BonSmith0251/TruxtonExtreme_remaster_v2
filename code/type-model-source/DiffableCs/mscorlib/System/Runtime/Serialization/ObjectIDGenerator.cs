namespace System.Runtime.Serialization;

[ComVisible(True)]
[Token(Token = "0x20003E8")]
public class ObjectIDGenerator
{
	[Token(Token = "0x4000F46")]
	private static readonly Int32[] sizes; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F42")]
	internal int m_currentCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000F43")]
	internal int m_currentSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F44")]
	internal Int64[] m_ids; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F45")]
	internal Object[] m_objs; //Field offset: 0x20

	[Address(RVA = "0x1F0DA80", Offset = "0x1F0CE80", Length = "0x8C")]
	[Token(Token = "0x6001DDF")]
	private static ObjectIDGenerator() { }

	[Address(RVA = "0x1F0DB10", Offset = "0x1F0CF10", Length = "0xDD")]
	[Token(Token = "0x6001DDA")]
	public ObjectIDGenerator() { }

	[Address(RVA = "0x1F0D420", Offset = "0x1F0C820", Length = "0xC5")]
	[Token(Token = "0x6001DDB")]
	private int FindElement(object obj, out bool found) { }

	[Address(RVA = "0x1F0D4F0", Offset = "0x1F0C8F0", Length = "0x198")]
	[Token(Token = "0x6001DDC")]
	public override long GetId(object obj, out bool firstTime) { }

	[Address(RVA = "0x1F0D690", Offset = "0x1F0CA90", Length = "0xD5")]
	[Token(Token = "0x6001DDD")]
	public override long HasId(object obj, out bool firstTime) { }

	[Address(RVA = "0x1F0D770", Offset = "0x1F0CB70", Length = "0x309")]
	[Token(Token = "0x6001DDE")]
	private void Rehash() { }

}

