namespace System.Reflection;

[Token(Token = "0x2000520")]
internal struct MonoPropertyInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001489")]
	public Type parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400148A")]
	public Type declaring_type; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400148B")]
	public string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400148C")]
	public MethodInfo get_method; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400148D")]
	public MethodInfo set_method; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400148E")]
	public PropertyAttributes attrs; //Field offset: 0x28

}

