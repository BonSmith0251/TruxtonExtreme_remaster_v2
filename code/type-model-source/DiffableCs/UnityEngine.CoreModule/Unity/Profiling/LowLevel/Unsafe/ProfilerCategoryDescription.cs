namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[Token(Token = "0x2000036")]
public struct ProfilerCategoryDescription
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000092")]
	public readonly ushort Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000093")]
	public readonly ushort Flags; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000094")]
	public readonly Color32 Color; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000095")]
	private readonly int reserved0; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000096")]
	public readonly int NameUtf8Len; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000097")]
	public readonly Byte* NameUtf8; //Field offset: 0x10

}

