namespace TMPro;

[Token(Token = "0x2000090")]
public class TMP_Style
{
	[Token(Token = "0x40004A4")]
	internal static TMP_Style k_NormalStyle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40004A5")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40004A6")]
	private int m_HashCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004A7")]
	private string m_OpeningDefinition; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004A8")]
	private string m_ClosingDefinition; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004A9")]
	private UInt32[] m_OpeningTagArray; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004AA")]
	private UInt32[] m_ClosingTagArray; //Field offset: 0x38

	[Token(Token = "0x1700010C")]
	public int hashCode
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 4
		[Address(RVA = "0x2F13780", Offset = "0x2F12B80", Length = "0x9")]
		[Token(Token = "0x60004CC")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700010B")]
	public string name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60004C9")]
		 get { } //Length: 5
		[Address(RVA = "0x2F13790", Offset = "0x2F12B90", Length = "0x3E")]
		[Token(Token = "0x60004CA")]
		 set { } //Length: 62
	}

	[Token(Token = "0x1700010A")]
	public static TMP_Style NormalStyle
	{
		[Address(RVA = "0x2F136A0", Offset = "0x2F12AA0", Length = "0xD6")]
		[Token(Token = "0x60004C8")]
		 get { } //Length: 214
	}

	[Token(Token = "0x1700010E")]
	public string styleClosingDefinition
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60004CE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000110")]
	public UInt32[] styleClosingTagArray
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60004D0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700010D")]
	public string styleOpeningDefinition
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60004CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700010F")]
	public UInt32[] styleOpeningTagArray
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60004CF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F135E0", Offset = "0x2F129E0", Length = "0xB6")]
	[Token(Token = "0x60004D1")]
	internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60004CB")]
	public int get_hashCode() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60004C9")]
	public string get_name() { }

	[Address(RVA = "0x2F136A0", Offset = "0x2F12AA0", Length = "0xD6")]
	[Token(Token = "0x60004C8")]
	public static TMP_Style get_NormalStyle() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60004CE")]
	public string get_styleClosingDefinition() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60004D0")]
	public UInt32[] get_styleClosingTagArray() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60004CD")]
	public string get_styleOpeningDefinition() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60004CF")]
	public UInt32[] get_styleOpeningTagArray() { }

	[Address(RVA = "0x2F13430", Offset = "0x2F12830", Length = "0x1A6")]
	[Token(Token = "0x60004D2")]
	public void RefreshStyle() { }

	[Address(RVA = "0x2F13780", Offset = "0x2F12B80", Length = "0x9")]
	[Token(Token = "0x60004CC")]
	public void set_hashCode(int value) { }

	[Address(RVA = "0x2F13790", Offset = "0x2F12B90", Length = "0x3E")]
	[Token(Token = "0x60004CA")]
	public void set_name(string value) { }

}

