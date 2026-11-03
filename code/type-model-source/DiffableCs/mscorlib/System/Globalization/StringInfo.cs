namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200056A")]
public class StringInfo
{
	[FieldOffset(Offset = "0x10")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016A7")]
	private string m_str; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016A8")]
	private Int32[] m_indexes; //Field offset: 0x18

	[Token(Token = "0x170005B4")]
	private Int32[] Indexes
	{
		[Address(RVA = "0x1F7BDF0", Offset = "0x1F7B1F0", Length = "0x48")]
		[Token(Token = "0x60027BD")]
		private get { } //Length: 72
	}

	[Token(Token = "0x170005B6")]
	public int LengthInTextElements
	{
		[Address(RVA = "0x1F7BE40", Offset = "0x1F7B240", Length = "0x5A")]
		[Token(Token = "0x60027C0")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170005B5")]
	public string String
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60027BE")]
		 get { } //Length: 5
		[Address(RVA = "0x1F7BEA0", Offset = "0x1F7B2A0", Length = "0xA1")]
		[Token(Token = "0x60027BF")]
		 set { } //Length: 161
	}

	[Address(RVA = "0x1F7BD10", Offset = "0x1F7B110", Length = "0xD0")]
	[Token(Token = "0x60027B7")]
	public StringInfo() { }

	[Address(RVA = "0x1F7BC60", Offset = "0x1F7B060", Length = "0xAD")]
	[Token(Token = "0x60027B8")]
	public StringInfo(string value) { }

	[Address(RVA = "0x1F7B820", Offset = "0x1F7AC20", Length = "0x8D")]
	[ComVisible(False)]
	[Token(Token = "0x60027BB")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1F7BDF0", Offset = "0x1F7B1F0", Length = "0x48")]
	[Token(Token = "0x60027BD")]
	private Int32[] get_Indexes() { }

	[Address(RVA = "0x1F7BE40", Offset = "0x1F7B240", Length = "0x5A")]
	[Token(Token = "0x60027C0")]
	public int get_LengthInTextElements() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60027BE")]
	public string get_String() { }

	[Address(RVA = "0x1F7B8B0", Offset = "0x1F7ACB0", Length = "0x10E")]
	[Token(Token = "0x60027C1")]
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[ComVisible(False)]
	[Token(Token = "0x60027BC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F7B9C0", Offset = "0x1F7ADC0", Length = "0x34")]
	[OnDeserialized]
	[Token(Token = "0x60027BA")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x1F7BA00", Offset = "0x1F7AE00", Length = "0x1E")]
	[OnDeserializing]
	[Token(Token = "0x60027B9")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x1F7BA20", Offset = "0x1F7AE20", Length = "0x238")]
	[Token(Token = "0x60027C2")]
	public static Int32[] ParseCombiningCharacters(string str) { }

	[Address(RVA = "0x1F7BEA0", Offset = "0x1F7B2A0", Length = "0xA1")]
	[Token(Token = "0x60027BF")]
	public void set_String(string value) { }

}

