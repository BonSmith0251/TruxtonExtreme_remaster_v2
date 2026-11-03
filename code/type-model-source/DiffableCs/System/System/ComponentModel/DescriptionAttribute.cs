namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x200014A")]
public class DescriptionAttribute : Attribute
{
	[Token(Token = "0x40005DA")]
	public static readonly DescriptionAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005DB")]
	private string <DescriptionValue>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000180")]
	public override string Description
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000827")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000181")]
	protected string DescriptionValue
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000828")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000829")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2647D10", Offset = "0x2647110", Length = "0x91")]
	[Token(Token = "0x600082D")]
	private static DescriptionAttribute() { }

	[Address(RVA = "0x2647DB0", Offset = "0x26471B0", Length = "0x3F")]
	[Token(Token = "0x6000825")]
	public DescriptionAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000826")]
	public DescriptionAttribute(string description) { }

	[Address(RVA = "0x2647B90", Offset = "0x2646F90", Length = "0xC4")]
	[Token(Token = "0x600082A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000827")]
	public override string get_Description() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000828")]
	protected string get_DescriptionValue() { }

	[Address(RVA = "0x2647C60", Offset = "0x2647060", Length = "0x3C")]
	[Token(Token = "0x600082B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2647CA0", Offset = "0x26470A0", Length = "0x6A")]
	[Token(Token = "0x600082C")]
	public virtual bool IsDefaultAttribute() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000829")]
	protected void set_DescriptionValue(string value) { }

}

