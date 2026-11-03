namespace System.ComponentModel;

[AttributeUsage(960)]
[Token(Token = "0x200014E")]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	[Token(Token = "0x40005E9")]
	public static readonly DesignerSerializationVisibilityAttribute Content; //Field offset: 0x0
	[Token(Token = "0x40005EA")]
	public static readonly DesignerSerializationVisibilityAttribute Hidden; //Field offset: 0x8
	[Token(Token = "0x40005EB")]
	public static readonly DesignerSerializationVisibilityAttribute Visible; //Field offset: 0x10
	[Token(Token = "0x40005EC")]
	public static readonly DesignerSerializationVisibilityAttribute Default; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005ED")]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000185")]
	public DesignerSerializationVisibility Visibility
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600083D")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x26484A0", Offset = "0x26478A0", Length = "0x133")]
	[Token(Token = "0x6000841")]
	private static DesignerSerializationVisibilityAttribute() { }

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600083C")]
	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) { }

	[Address(RVA = "0x2648370", Offset = "0x2647770", Length = "0xB6")]
	[Token(Token = "0x600083E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600083D")]
	public DesignerSerializationVisibility get_Visibility() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x600083F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2648430", Offset = "0x2647830", Length = "0x6B")]
	[Token(Token = "0x6000840")]
	public virtual bool IsDefaultAttribute() { }

}

