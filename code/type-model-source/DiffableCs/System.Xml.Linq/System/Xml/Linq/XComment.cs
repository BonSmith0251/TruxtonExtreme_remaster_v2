namespace System.Xml.Linq;

[Token(Token = "0x2000008")]
public class XComment : XNode
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000007")]
	internal string value; //Field offset: 0x28

	[Token(Token = "0x17000006")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000007")]
	public string Value
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 5
		[Address(RVA = "0x2407EE0", Offset = "0x24072E0", Length = "0x11B")]
		[Token(Token = "0x6000019")]
		 set { } //Length: 283
	}

	[Address(RVA = "0x2407E60", Offset = "0x2407260", Length = "0x7E")]
	[Token(Token = "0x6000015")]
	public XComment(string value) { }

	[Address(RVA = "0x2407DE0", Offset = "0x24071E0", Length = "0x7F")]
	[Token(Token = "0x6000016")]
	public XComment(XComment other) { }

	[Address(RVA = "0x2407CB0", Offset = "0x24070B0", Length = "0xAE")]
	[Token(Token = "0x600001B")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x6000017")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000018")]
	public string get_Value() { }

	[Address(RVA = "0x2407EE0", Offset = "0x24072E0", Length = "0x11B")]
	[Token(Token = "0x6000019")]
	public void set_Value(string value) { }

	[Address(RVA = "0x2407D60", Offset = "0x2407160", Length = "0x7D")]
	[Token(Token = "0x600001A")]
	public virtual void WriteTo(XmlWriter writer) { }

}

