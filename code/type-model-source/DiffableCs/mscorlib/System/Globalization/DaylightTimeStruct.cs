namespace System.Globalization;

[IsReadOnly]
[Token(Token = "0x200054B")]
internal struct DaylightTimeStruct
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015A8")]
	public readonly DateTime Start; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40015A9")]
	public readonly DateTime End; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015AA")]
	public readonly TimeSpan Delta; //Field offset: 0x10

	[Address(RVA = "0x1F73700", Offset = "0x1F72B00", Length = "0xC")]
	[Token(Token = "0x60026BF")]
	public DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta) { }

}

