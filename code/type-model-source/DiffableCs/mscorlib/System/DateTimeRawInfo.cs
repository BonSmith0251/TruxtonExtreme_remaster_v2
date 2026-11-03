namespace System;

[Token(Token = "0x20000E4")]
internal struct DateTimeRawInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400035A")]
	private Int32* num; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400035B")]
	internal int numCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400035C")]
	internal int month; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035D")]
	internal int year; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400035E")]
	internal int dayOfWeek; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400035F")]
	internal int era; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000360")]
	internal TM timeMark; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000361")]
	internal double fraction; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000362")]
	internal bool hasSameDateAndTimeSeparators; //Field offset: 0x28

	[Address(RVA = "0x20218E0", Offset = "0x2020CE0", Length = "0x13")]
	[Token(Token = "0x6000746")]
	internal void AddNumber(int value) { }

	[Address(RVA = "0x11B1DE0", Offset = "0x11B11E0", Length = "0xA")]
	[Token(Token = "0x6000747")]
	internal int GetNumber(int index) { }

	[Address(RVA = "0x2021900", Offset = "0x2020D00", Length = "0x29")]
	[Token(Token = "0x6000745")]
	internal void Init(Int32* numberBuffer) { }

}

