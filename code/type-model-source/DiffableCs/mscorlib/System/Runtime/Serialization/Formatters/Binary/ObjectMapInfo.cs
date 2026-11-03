namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000425")]
internal sealed class ObjectMapInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010B1")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40010B2")]
	private int numMembers; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010B3")]
	private String[] memberNames; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010B4")]
	private Type[] memberTypes; //Field offset: 0x20

	[Address(RVA = "0x1F1D210", Offset = "0x1F1C610", Length = "0x62")]
	[Token(Token = "0x6001F3C")]
	internal ObjectMapInfo(int objectId, int numMembers, String[] memberNames, Type[] memberTypes) { }

	[Address(RVA = "0x1F1D280", Offset = "0x1F1C680", Length = "0x121")]
	[Token(Token = "0x6001F3D")]
	internal bool isCompatible(int numMembers, String[] memberNames, Type[] memberTypes) { }

}

