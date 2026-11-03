namespace System.Xml.Linq;

[Token(Token = "0x2000022")]
public class XProcessingInstruction : XNode
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000059")]
	internal string target; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005A")]
	internal string data; //Field offset: 0x30

	[Token(Token = "0x1700002A")]
	public string Data
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 5
		[Address(RVA = "0x240F560", Offset = "0x240E960", Length = "0x11B")]
		[Token(Token = "0x60000DB")]
		 set { } //Length: 283
	}

	[Token(Token = "0x1700002B")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700002C")]
	public string Target
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x240F360", Offset = "0x240E760", Length = "0x15C")]
	[Token(Token = "0x60000D8")]
	public XProcessingInstruction(string target, string data) { }

	[Address(RVA = "0x240F4C0", Offset = "0x240E8C0", Length = "0x90")]
	[Token(Token = "0x60000D9")]
	public XProcessingInstruction(XProcessingInstruction other) { }

	[Address(RVA = "0x240F130", Offset = "0x240E530", Length = "0xBF")]
	[Token(Token = "0x60000DF")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60000DA")]
	public string get_Data() { }

	[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
	[Token(Token = "0x60000DC")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000DD")]
	public string get_Target() { }

	[Address(RVA = "0x240F560", Offset = "0x240E960", Length = "0x11B")]
	[Token(Token = "0x60000DB")]
	public void set_Data(string value) { }

	[Address(RVA = "0x240F1F0", Offset = "0x240E5F0", Length = "0xD5")]
	[Token(Token = "0x60000E0")]
	private static void ValidateName(string name) { }

	[Address(RVA = "0x240F2D0", Offset = "0x240E6D0", Length = "0x81")]
	[Token(Token = "0x60000DE")]
	public virtual void WriteTo(XmlWriter writer) { }

}

