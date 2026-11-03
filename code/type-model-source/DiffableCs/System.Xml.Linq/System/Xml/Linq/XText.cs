namespace System.Xml.Linq;

[Token(Token = "0x2000024")]
public class XText : XNode
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005D")]
	internal string text; //Field offset: 0x28

	[Token(Token = "0x1700002D")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700002E")]
	public string Value
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 5
		[Address(RVA = "0x240F850", Offset = "0x240EC50", Length = "0x11B")]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 283
	}

	[Address(RVA = "0x2407BB0", Offset = "0x2406FB0", Length = "0x7E")]
	[Token(Token = "0x60000E1")]
	public XText(string value) { }

	[Address(RVA = "0x2407C30", Offset = "0x2407030", Length = "0x7F")]
	[Token(Token = "0x60000E2")]
	public XText(XText other) { }

	[Address(RVA = "0x240F680", Offset = "0x240EA80", Length = "0x24")]
	[Token(Token = "0x60000E7")]
	internal virtual void AppendText(StringBuilder sb) { }

	[Address(RVA = "0x240F6B0", Offset = "0x240EAB0", Length = "0xAE")]
	[Token(Token = "0x60000E8")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x60000E3")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000E4")]
	public string get_Value() { }

	[Address(RVA = "0x240F850", Offset = "0x240EC50", Length = "0x11B")]
	[Token(Token = "0x60000E5")]
	public void set_Value(string value) { }

	[Address(RVA = "0x240F760", Offset = "0x240EB60", Length = "0xE5")]
	[Token(Token = "0x60000E6")]
	public virtual void WriteTo(XmlWriter writer) { }

}

