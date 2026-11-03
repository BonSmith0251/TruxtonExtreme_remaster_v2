namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x20001A8")]
public class CategoryAttribute : Attribute
{
	[Token(Token = "0x4000673")]
	private static CategoryAttribute defAttr; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000674")]
	private bool localized; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000675")]
	private string categoryValue; //Field offset: 0x18

	[Token(Token = "0x170001F4")]
	public string Category
	{
		[Address(RVA = "0x265C110", Offset = "0x265B510", Length = "0x53")]
		[Token(Token = "0x6000A34")]
		 get { } //Length: 83
	}

	[Token(Token = "0x170001F3")]
	public static CategoryAttribute Default
	{
		[Address(RVA = "0x265C170", Offset = "0x265B570", Length = "0xE5")]
		[Token(Token = "0x6000A31")]
		 get { } //Length: 229
	}

	[Address(RVA = "0x265C070", Offset = "0x265B470", Length = "0x59")]
	[Token(Token = "0x6000A32")]
	public CategoryAttribute() { }

	[Address(RVA = "0x265C0D0", Offset = "0x265B4D0", Length = "0x36")]
	[Token(Token = "0x6000A33")]
	public CategoryAttribute(string category) { }

	[Address(RVA = "0x265B900", Offset = "0x265AD00", Length = "0x159")]
	[Token(Token = "0x6000A35")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x265C110", Offset = "0x265B510", Length = "0x53")]
	[Token(Token = "0x6000A34")]
	public string get_Category() { }

	[Address(RVA = "0x265C170", Offset = "0x265B570", Length = "0xE5")]
	[Token(Token = "0x6000A31")]
	public static CategoryAttribute get_Default() { }

	[Address(RVA = "0x265BA60", Offset = "0x265AE60", Length = "0x66")]
	[Token(Token = "0x6000A36")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x265BAD0", Offset = "0x265AED0", Length = "0x41F")]
	[Token(Token = "0x6000A37")]
	protected override string GetLocalizedString(string value) { }

	[Address(RVA = "0x265BEF0", Offset = "0x265B2F0", Length = "0x17E")]
	[Token(Token = "0x6000A38")]
	public virtual bool IsDefaultAttribute() { }

}

