namespace System;

[Token(Token = "0x200012B")]
public class ResolveEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000438")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000439")]
	private readonly Assembly <RequestingAssembly>k__BackingField; //Field offset: 0x18

	[Address(RVA = "0x2047110", Offset = "0x2046510", Length = "0x65")]
	[Token(Token = "0x60009A0")]
	public ResolveEventArgs(string name) { }

	[Address(RVA = "0x2047080", Offset = "0x2046480", Length = "0x82")]
	[Token(Token = "0x60009A1")]
	public ResolveEventArgs(string name, Assembly requestingAssembly) { }

}

