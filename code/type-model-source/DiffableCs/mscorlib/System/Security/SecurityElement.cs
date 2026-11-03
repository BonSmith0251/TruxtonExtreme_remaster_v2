namespace System.Security;

[ComVisible(True)]
[Token(Token = "0x20002D2")]
public sealed class SecurityElement
{
	[Token(Token = "0x20002D3")]
	public class SecurityAttribute
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C26")]
		private string _name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C27")]
		private string _value; //Field offset: 0x18

		[Token(Token = "0x17000257")]
		public string Name
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60017CA")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000258")]
		public string Value
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60017CB")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1EAAB30", Offset = "0x1EA9F30", Length = "0x261")]
		[Token(Token = "0x60017C9")]
		public SecurityAttribute(string name, string value) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60017CA")]
		public string get_Name() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60017CB")]
		public string get_Value() { }

	}

	[Token(Token = "0x4000C21")]
	private static readonly Char[] invalid_tag_chars; //Field offset: 0x0
	[Token(Token = "0x4000C22")]
	private static readonly Char[] invalid_text_chars; //Field offset: 0x8
	[Token(Token = "0x4000C23")]
	private static readonly Char[] invalid_attr_name_chars; //Field offset: 0x10
	[Token(Token = "0x4000C24")]
	private static readonly Char[] invalid_attr_value_chars; //Field offset: 0x18
	[Token(Token = "0x4000C25")]
	private static readonly Char[] invalid_chars; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C1D")]
	private string text; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C1E")]
	private string tag; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C1F")]
	private ArrayList attributes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C20")]
	private ArrayList children; //Field offset: 0x28

	[Token(Token = "0x17000253")]
	public ArrayList Children
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60017B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000256")]
	internal string m_strText
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60017C6")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000254")]
	public string Tag
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60017B8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000255")]
	public string Text
	{
		[Address(RVA = "0x1EAD140", Offset = "0x1EAC540", Length = "0x147")]
		[Token(Token = "0x60017B9")]
		 set { } //Length: 327
	}

	[Address(RVA = "0x1EACC50", Offset = "0x1EAC050", Length = "0x20B")]
	[Token(Token = "0x60017C8")]
	private static SecurityElement() { }

	[Address(RVA = "0x1EACE60", Offset = "0x1EAC260", Length = "0xB")]
	[Token(Token = "0x60017B5")]
	public SecurityElement(string tag) { }

	[Address(RVA = "0x1EACE70", Offset = "0x1EAC270", Length = "0x2C1")]
	[Token(Token = "0x60017B6")]
	public SecurityElement(string tag, string text) { }

	[Address(RVA = "0x1EAB830", Offset = "0x1EAAC30", Length = "0x1EF")]
	[Token(Token = "0x60017BA")]
	public void AddAttribute(string name, string value) { }

	[Address(RVA = "0x1EABA20", Offset = "0x1EAAE20", Length = "0xE3")]
	[Token(Token = "0x60017BB")]
	public void AddChild(SecurityElement child) { }

	[Address(RVA = "0x1EABB10", Offset = "0x1EAAF10", Length = "0x214")]
	[Token(Token = "0x60017BC")]
	public static string Escape(string str) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60017B7")]
	public ArrayList get_Children() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60017B8")]
	public string get_Tag() { }

	[Address(RVA = "0x1EABD30", Offset = "0x1EAB130", Length = "0x1B2")]
	[Token(Token = "0x60017C5")]
	internal SecurityAttribute GetAttribute(string name) { }

	[Address(RVA = "0x1EABEF0", Offset = "0x1EAB2F0", Length = "0x73")]
	[Token(Token = "0x60017BE")]
	public static bool IsValidAttributeName(string name) { }

	[Address(RVA = "0x1EABF70", Offset = "0x1EAB370", Length = "0x73")]
	[Token(Token = "0x60017BF")]
	public static bool IsValidAttributeValue(string value) { }

	[Address(RVA = "0x1EABFF0", Offset = "0x1EAB3F0", Length = "0x72")]
	[Token(Token = "0x60017C0")]
	public static bool IsValidTag(string tag) { }

	[Address(RVA = "0x1EAC070", Offset = "0x1EAB470", Length = "0x73")]
	[Token(Token = "0x60017C1")]
	public static bool IsValidText(string text) { }

	[Address(RVA = "0x1EAC0F0", Offset = "0x1EAB4F0", Length = "0x154")]
	[Token(Token = "0x60017C2")]
	public SecurityElement SearchForChildByTag(string tag) { }

	[Address(RVA = "0x1EAC250", Offset = "0x1EAB650", Length = "0x1F3")]
	[Token(Token = "0x60017C7")]
	internal string SearchForTextOfLocalName(string strLocalName) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60017C6")]
	internal void set_m_strText(string value) { }

	[Address(RVA = "0x1EAD140", Offset = "0x1EAC540", Length = "0x147")]
	[Token(Token = "0x60017B9")]
	public void set_Text(string value) { }

	[Address(RVA = "0x1EAC450", Offset = "0x1EAB850", Length = "0x90")]
	[Token(Token = "0x60017C3")]
	public virtual string ToString() { }

	[Address(RVA = "0x1EAC4F0", Offset = "0x1EAB8F0", Length = "0x5CA")]
	[Token(Token = "0x60017C4")]
	private void ToXml(ref StringBuilder s, int level) { }

	[Address(RVA = "0x1EACAC0", Offset = "0x1EABEC0", Length = "0x180")]
	[Token(Token = "0x60017BD")]
	private static string Unescape(string str) { }

}

