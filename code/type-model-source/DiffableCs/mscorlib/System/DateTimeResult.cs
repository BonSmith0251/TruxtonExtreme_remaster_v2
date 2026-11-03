namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000E7")]
internal struct DateTimeResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400037C")]
	internal int Year; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400037D")]
	internal int Month; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400037E")]
	internal int Day; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400037F")]
	internal int Hour; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000380")]
	internal int Minute; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000381")]
	internal int Second; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000382")]
	internal double fraction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000383")]
	internal int era; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000384")]
	internal ParseFlags flags; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000385")]
	internal TimeSpan timeZoneOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000386")]
	internal Calendar calendar; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000387")]
	internal DateTime parsedDate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000388")]
	internal ParseFailureKind failure; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000389")]
	internal string failureMessageID; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400038A")]
	internal object failureMessageFormatArgument; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400038B")]
	internal string failureArgumentName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400038C")]
	internal ReadOnlySpan<Char> originalDateTimeString; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400038D")]
	internal ReadOnlySpan<Char> failedFormatSpecifier; //Field offset: 0x70

	[Address(RVA = "0x2021930", Offset = "0x2020D30", Length = "0x2B")]
	[Token(Token = "0x6000748")]
	internal void Init(ReadOnlySpan<Char> originalDateTimeString) { }

	[Address(RVA = "0x2021960", Offset = "0x2020D60", Length = "0x45")]
	[Token(Token = "0x600074C")]
	internal void SetBadDateTimeFailure() { }

	[Address(RVA = "0x2021A00", Offset = "0x2020E00", Length = "0x73")]
	[Token(Token = "0x600074A")]
	internal void SetBadFormatSpecifierFailure() { }

	[Address(RVA = "0x20219B0", Offset = "0x2020DB0", Length = "0x50")]
	[Token(Token = "0x600074B")]
	internal void SetBadFormatSpecifierFailure(ReadOnlySpan<Char> failedFormatSpecifier) { }

	[Address(RVA = "0x12F4C60", Offset = "0x12F4060", Length = "0xB")]
	[Token(Token = "0x6000749")]
	internal void SetDate(int year, int month, int day) { }

	[Address(RVA = "0x2021AB0", Offset = "0x2020EB0", Length = "0x10")]
	[Token(Token = "0x600074D")]
	internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

	[Address(RVA = "0x2021A80", Offset = "0x2020E80", Length = "0xC")]
	[Token(Token = "0x600074E")]
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	[Address(RVA = "0x2021A90", Offset = "0x2020E90", Length = "0x15")]
	[Token(Token = "0x600074F")]
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

}

