namespace System;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
[Token(Token = "0x20000BC")]
public sealed class AttributeUsageAttribute : Attribute
{
	[Token(Token = "0x400029D")]
	internal static AttributeUsageAttribute Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400029A")]
	private AttributeTargets _attributeTarget; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400029B")]
	private bool _allowMultiple; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x400029C")]
	private bool _inherited; //Field offset: 0x15

	[Token(Token = "0x1700005A")]
	public bool AllowMultiple
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x600041E")]
		 get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[Token(Token = "0x600041F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700005B")]
	public bool Inherited
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x6000420")]
		 get { } //Length: 5
		[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
		[Token(Token = "0x6000421")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1F8C930", Offset = "0x1F8BD30", Length = "0x79")]
	[Token(Token = "0x6000422")]
	private static AttributeUsageAttribute() { }

	[Address(RVA = "0x1F8C9B0", Offset = "0x1F8BDB0", Length = "0x2F")]
	[Token(Token = "0x600041D")]
	public AttributeUsageAttribute(AttributeTargets validOn) { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x600041E")]
	public bool get_AllowMultiple() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x6000420")]
	public bool get_Inherited() { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x600041F")]
	public void set_AllowMultiple(bool value) { }

	[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
	[Token(Token = "0x6000421")]
	public void set_Inherited(bool value) { }

}

