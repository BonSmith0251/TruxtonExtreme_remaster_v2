namespace System.ComponentModel;

[Token(Token = "0x2000164")]
public class CollectionChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060B")]
	private readonly CollectionChangeAction <Action>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400060C")]
	private readonly object <Element>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700019C")]
	public override CollectionChangeAction Action
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000893")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700019D")]
	public override object Element
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000894")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2642B10", Offset = "0x2641F10", Length = "0x74")]
	[Token(Token = "0x6000892")]
	public CollectionChangeEventArgs(CollectionChangeAction action, object element) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000893")]
	public override CollectionChangeAction get_Action() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000894")]
	public override object get_Element() { }

}

