namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x200016F")]
public class ToolboxItemAttribute : Attribute
{
	[Token(Token = "0x4000618")]
	public static readonly ToolboxItemAttribute Default; //Field offset: 0x0
	[Token(Token = "0x4000619")]
	public static readonly ToolboxItemAttribute None; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000617")]
	private string _toolboxItemTypeName; //Field offset: 0x10

	[Token(Token = "0x170001A4")]
	public string ToolboxItemTypeName
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x60008D5")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x2678840", Offset = "0x2677C40", Length = "0x148")]
	[Token(Token = "0x60008D8")]
	private static ToolboxItemAttribute() { }

	[Address(RVA = "0x2678A20", Offset = "0x2677E20", Length = "0x61")]
	[Token(Token = "0x60008D3")]
	public ToolboxItemAttribute(bool defaultType) { }

	[Address(RVA = "0x2678990", Offset = "0x2677D90", Length = "0x84")]
	[Token(Token = "0x60008D4")]
	public ToolboxItemAttribute(string toolboxItemTypeName) { }

	[Address(RVA = "0x26786C0", Offset = "0x2677AC0", Length = "0xC4")]
	[Token(Token = "0x60008D6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x60008D5")]
	public string get_ToolboxItemTypeName() { }

	[Address(RVA = "0x2678790", Offset = "0x2677B90", Length = "0x3C")]
	[Token(Token = "0x60008D7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26787D0", Offset = "0x2677BD0", Length = "0x6A")]
	[Token(Token = "0x60008D2")]
	public virtual bool IsDefaultAttribute() { }

}

