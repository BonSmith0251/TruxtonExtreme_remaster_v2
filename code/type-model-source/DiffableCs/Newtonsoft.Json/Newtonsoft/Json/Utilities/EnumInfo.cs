namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000C1")]
internal class EnumInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400043D")]
	public readonly bool IsFlags; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400043E")]
	public readonly UInt64[] Values; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400043F")]
	public readonly String[] Names; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000440")]
	public readonly String[] ResolvedNames; //Field offset: 0x28

	[Address(RVA = "0x2123D50", Offset = "0x2123150", Length = "0x70")]
	[Token(Token = "0x60005FA")]
	public EnumInfo(bool isFlags, UInt64[] values, String[] names, String[] resolvedNames) { }

}

