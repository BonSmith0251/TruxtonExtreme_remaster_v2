namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000040")]
public class TextStyle
{
	[Token(Token = "0x40001B9")]
	internal static TextStyle k_NormalStyle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40001BA")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40001BB")]
	private int m_HashCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001BC")]
	private string m_OpeningDefinition; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001BD")]
	private string m_ClosingDefinition; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001BE")]
	private UInt32[] m_OpeningTagArray; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001BF")]
	private UInt32[] m_ClosingTagArray; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40001C0")]
	internal UInt32[] m_OpeningTagUnicodeArray; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40001C1")]
	internal UInt32[] m_ClosingTagUnicodeArray; //Field offset: 0x48

	[Token(Token = "0x17000056")]
	public int hashCode
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x60001CF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000058")]
	public string styleClosingDefinition
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x60001D1")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700005A")]
	public UInt32[] styleClosingTagArray
	{
		[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
		[Token(Token = "0x60001D3")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000057")]
	public string styleOpeningDefinition
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x60001D0")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000059")]
	public UInt32[] styleOpeningTagArray
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x60001D2")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x31C3700", Offset = "0x31C2B00", Length = "0x82")]
	[Token(Token = "0x60001D4")]
	internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x60001CF")]
	public int get_hashCode() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x60001D1")]
	public string get_styleClosingDefinition() { }

	[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
	[Token(Token = "0x60001D3")]
	public UInt32[] get_styleClosingTagArray() { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x60001D0")]
	public string get_styleOpeningDefinition() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x60001D2")]
	public UInt32[] get_styleOpeningTagArray() { }

	[Address(RVA = "0x31C34E0", Offset = "0x31C28E0", Length = "0x21E")]
	[Token(Token = "0x60001D5")]
	public void RefreshStyle() { }

}

