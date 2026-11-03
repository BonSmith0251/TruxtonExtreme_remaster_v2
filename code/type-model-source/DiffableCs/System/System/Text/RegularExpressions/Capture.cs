namespace System.Text.RegularExpressions;

[Token(Token = "0x20000D5")]
public class Capture
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000346")]
	private int <Index>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000347")]
	private int <Length>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000348")]
	private string <Text>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000B3")]
	public int Index
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600044B")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600044C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B4")]
	public int Length
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600044D")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600044E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B5")]
	internal string Text
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600044F")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000450")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000B6")]
	public string Value
	{
		[Address(RVA = "0x2615200", Offset = "0x2614600", Length = "0x28")]
		[Token(Token = "0x6000451")]
		 get { } //Length: 40
	}

	[Address(RVA = "0x2615260", Offset = "0x2614660", Length = "0x52")]
	[Token(Token = "0x600044A")]
	internal Capture(string text, int index, int length) { }

	[Address(RVA = "0x2615230", Offset = "0x2614630", Length = "0x2C")]
	[Token(Token = "0x6000455")]
	internal Capture() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600044B")]
	public int get_Index() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600044D")]
	public int get_Length() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600044F")]
	internal string get_Text() { }

	[Address(RVA = "0x2615200", Offset = "0x2614600", Length = "0x28")]
	[Token(Token = "0x6000451")]
	public string get_Value() { }

	[Address(RVA = "0x26150A0", Offset = "0x26144A0", Length = "0x96")]
	[Token(Token = "0x6000453")]
	internal ReadOnlySpan<Char> GetLeftSubstring() { }

	[Address(RVA = "0x2615140", Offset = "0x2614540", Length = "0xB1")]
	[Token(Token = "0x6000454")]
	internal ReadOnlySpan<Char> GetRightSubstring() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600044C")]
	 void set_Index(int value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600044E")]
	 void set_Length(int value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000450")]
	 void set_Text(string value) { }

	[Address(RVA = "0x2615200", Offset = "0x2614600", Length = "0x28")]
	[Token(Token = "0x6000452")]
	public virtual string ToString() { }

}

