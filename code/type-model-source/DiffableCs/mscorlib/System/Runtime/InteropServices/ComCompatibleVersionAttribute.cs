namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000457")]
public sealed class ComCompatibleVersionAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001219")]
	internal int _major; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400121A")]
	internal int _minor; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400121B")]
	internal int _build; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400121C")]
	internal int _revision; //Field offset: 0x1C

	[Address(RVA = "0x1F33070", Offset = "0x1F32470", Length = "0x4B")]
	[Token(Token = "0x6002038")]
	public ComCompatibleVersionAttribute(int major, int minor, int build, int revision) { }

}

