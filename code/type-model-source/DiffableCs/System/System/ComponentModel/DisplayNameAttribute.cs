namespace System.ComponentModel;

[AttributeUsage(708)]
[Token(Token = "0x200014F")]
public class DisplayNameAttribute : Attribute
{
	[Token(Token = "0x40005EE")]
	public static readonly DisplayNameAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005EF")]
	private string <DisplayNameValue>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000186")]
	public override string DisplayName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000844")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000187")]
	protected string DisplayNameValue
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000845")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000846")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2648720", Offset = "0x2647B20", Length = "0x91")]
	[Token(Token = "0x600084A")]
	private static DisplayNameAttribute() { }

	[Address(RVA = "0x2647DB0", Offset = "0x26471B0", Length = "0x3F")]
	[Token(Token = "0x6000842")]
	public DisplayNameAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000843")]
	public DisplayNameAttribute(string displayName) { }

	[Address(RVA = "0x26485E0", Offset = "0x26479E0", Length = "0xC4")]
	[Token(Token = "0x6000847")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000844")]
	public override string get_DisplayName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000845")]
	protected string get_DisplayNameValue() { }

	[Address(RVA = "0x2647C60", Offset = "0x2647060", Length = "0x3C")]
	[Token(Token = "0x6000848")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26486B0", Offset = "0x2647AB0", Length = "0x6A")]
	[Token(Token = "0x6000849")]
	public virtual bool IsDefaultAttribute() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000846")]
	protected void set_DisplayNameValue(string value) { }

}

