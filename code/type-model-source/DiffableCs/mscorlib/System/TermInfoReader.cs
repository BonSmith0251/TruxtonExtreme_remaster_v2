namespace System;

[Token(Token = "0x20001CE")]
internal class TermInfoReader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400077A")]
	private int boolSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400077B")]
	private int numSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400077C")]
	private int strOffsets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400077D")]
	private Byte[] buffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400077E")]
	private int booleansOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400077F")]
	private int intOffset; //Field offset: 0x2C

	[Address(RVA = "0x2090100", Offset = "0x208F500", Length = "0x21A")]
	[Token(Token = "0x600107B")]
	public TermInfoReader(string term, string filename) { }

	[Address(RVA = "0x2090060", Offset = "0x208F460", Length = "0x9B")]
	[Token(Token = "0x600107C")]
	public TermInfoReader(string term, Byte[] buffer) { }

	[Address(RVA = "0x208F750", Offset = "0x208EB50", Length = "0xB6")]
	[Token(Token = "0x600107D")]
	private void DetermineVersion(short magic) { }

	[Address(RVA = "0x208FC80", Offset = "0x208F080", Length = "0xB4")]
	[Token(Token = "0x6001080")]
	public int Get(TermInfoNumbers number) { }

	[Address(RVA = "0x208FB20", Offset = "0x208EF20", Length = "0x152")]
	[Token(Token = "0x6001081")]
	public string Get(TermInfoStrings tstr) { }

	[Address(RVA = "0x208F810", Offset = "0x208EC10", Length = "0x5C")]
	[Token(Token = "0x6001083")]
	private short GetInt16(Byte[] buffer, int offset) { }

	[Address(RVA = "0x208FA90", Offset = "0x208EE90", Length = "0x8F")]
	[Token(Token = "0x6001084")]
	private string GetString(Byte[] buffer, int offset) { }

	[Address(RVA = "0x208F920", Offset = "0x208ED20", Length = "0x16F")]
	[Token(Token = "0x6001082")]
	public Byte[] GetStringBytes(TermInfoStrings tstr) { }

	[Address(RVA = "0x208F870", Offset = "0x208EC70", Length = "0xAE")]
	[Token(Token = "0x6001085")]
	private Byte[] GetStringBytes(Byte[] buffer, int offset) { }

	[Address(RVA = "0x208FD40", Offset = "0x208F140", Length = "0x26C")]
	[Token(Token = "0x600107E")]
	private void ReadHeader(Byte[] buffer, ref int position) { }

	[Address(RVA = "0x208FFB0", Offset = "0x208F3B0", Length = "0xA1")]
	[Token(Token = "0x600107F")]
	private void ReadNames(Byte[] buffer, ref int position) { }

}

