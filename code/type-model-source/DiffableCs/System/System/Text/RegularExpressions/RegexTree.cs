namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F5")]
internal sealed class RegexTree
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000446")]
	public readonly RegexNode Root; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000447")]
	public readonly Hashtable Caps; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000448")]
	public readonly Int32[] CapNumList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000449")]
	public readonly int CapTop; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400044A")]
	public readonly Hashtable CapNames; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400044B")]
	public readonly String[] CapsList; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400044C")]
	public readonly RegexOptions Options; //Field offset: 0x40

	[Address(RVA = "0x263B770", Offset = "0x263AB70", Length = "0x9E")]
	[Token(Token = "0x6000609")]
	internal RegexTree(RegexNode root, Hashtable caps, Int32[] capNumList, int capTop, Hashtable capNames, String[] capsList, RegexOptions options) { }

}

