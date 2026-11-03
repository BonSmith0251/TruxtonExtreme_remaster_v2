namespace System.Reflection;

[ComVisible(True)]
[Token(Token = "0x2000515")]
public class LocalVariableInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400145A")]
	internal Type type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400145B")]
	internal bool is_pinned; //Field offset: 0x18
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x400145C")]
	internal ushort position; //Field offset: 0x1A

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600242C")]
	protected LocalVariableInfo() { }

	[Address(RVA = "0x1F5EDA0", Offset = "0x1F5E1A0", Length = "0x87")]
	[Token(Token = "0x600242D")]
	public virtual string ToString() { }

}

