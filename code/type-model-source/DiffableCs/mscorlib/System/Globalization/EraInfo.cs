namespace System.Globalization;

[Token(Token = "0x2000564")]
internal class EraInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001663")]
	internal int era; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001664")]
	internal long ticks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001665")]
	internal int yearOffset; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001666")]
	internal int minEraYear; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001667")]
	internal int maxEraYear; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x4001668")]
	internal string eraName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x4001669")]
	internal string abbrevEraName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x400166A")]
	internal string englishEraName; //Field offset: 0x40

	[Address(RVA = "0x1F73830", Offset = "0x1F72C30", Length = "0xD6")]
	[Token(Token = "0x6002740")]
	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	[Address(RVA = "0x1F73710", Offset = "0x1F72B10", Length = "0x115")]
	[Token(Token = "0x6002741")]
	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

