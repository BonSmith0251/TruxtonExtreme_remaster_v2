namespace System.Reflection;

[ComVisible(True)]
[Token(Token = "0x2000514")]
public class ExceptionHandlingClause
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001453")]
	internal Type catch_type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001454")]
	internal int filter_offset; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001455")]
	internal ExceptionHandlingClauseOptions flags; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001456")]
	internal int try_offset; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001457")]
	internal int try_length; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001458")]
	internal int handler_offset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001459")]
	internal int handler_length; //Field offset: 0x2C

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600242A")]
	protected ExceptionHandlingClause() { }

	[Address(RVA = "0x1F5DE50", Offset = "0x1F5D250", Length = "0x302")]
	[Token(Token = "0x600242B")]
	public virtual string ToString() { }

}

